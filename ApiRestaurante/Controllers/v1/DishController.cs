using ApiRestaurante.Core.Application.Interfaces.Services;
using ApiRestaurante.Core.Application.ViewModels.Dish;
using ApiRestaurante.Core.Application.ViewModels.Ingredient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante.Presentation.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class DishController : BaseApiController
    {
        private readonly IDishService _dishService;
        private readonly IIngredientService _ingService;

        public DishController(IDishService dishService,IIngredientService ingredientService)
        {
            _dishService = dishService;
            _ingService = ingredientService;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(SaveDishViewModel vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(vm);
                }

                if (vm.IngredientIds.Count == 0)
                {
                    vm.HasError = true;
                    vm.Error = "Debes añadir al menos un ingrediente";
                    return BadRequest(vm);
                }

                foreach(var id in vm.IngredientIds)
                {
                    var ingredient = await _ingService.GetByIdSaveViewModel(id);
                    if (ingredient == null)
                    {
                        vm.HasError = true;
                        vm.Error = $"No existe un ingrediente con el id {id}";
                        return BadRequest(vm);
                    }
                }

                var dish = await _dishService.Add(vm);
                if (dish == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, dish);
                }

                foreach (var id in vm.IngredientIds)
                {
                    await _dishService.AddIngredientToDish(dish.Id, id);
                }               

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpPut("Update/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DishViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Put(int id, SaveDishViewModel vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(vm);
                }

                var dish = await _dishService.GetByIdViewModel(id);
                if (dish == null)
                {
                    vm.HasError = true;
                    vm.Error = $"No existe un plato con el id {id}";
                    return BadRequest(vm);
                }

                if (vm.IngredientIds.Count == 0)
                {
                    vm.HasError = true;
                    vm.Error = "Debes añadir al menos un ingrediente";
                    return BadRequest(vm);
                }

                foreach (var ingId in vm.IngredientIds)
                {
                    var ingredient = await _ingService.GetByIdSaveViewModel(ingId);
                    if (ingredient == null)
                    {
                        vm.HasError = true;
                        vm.Error = $"No existe un ingrediente con el id {ingId}";
                        return BadRequest(vm);
                    }
                }

                List<int> forAdd = new();
                List<int> forDelete = new();

                var ingsByDish = await _dishService.GetAllIngredientIdsByDish(id);

                foreach (int ingId in vm.IngredientIds)
                {
                    if (!ingsByDish.Any(i => i.IngredientId == ingId))
                        forAdd.Add(ingId);
                }

                foreach (var ing in ingsByDish)
                {
                    if (!vm.IngredientIds.Contains(ing.IngredientId))
                        forDelete.Add(ing.IngredientId);
                }

                foreach (var del in forDelete)
                {
                    await _dishService.DeleteIngredientFromDish(del, id);
                }

                vm.Id = id;
                await _dishService.Update(vm, id);

                foreach (var add in forAdd)
                {
                    await _dishService.AddIngredientToDish(id, add);
                }

                return Ok(await _dishService.GetDishWithIngredients(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet("List")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DishViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<DishViewModel> dishes = await _dishService.GetAllWithIngredients();

                if (dishes.Count == 0)
                    return NotFound();

                return Ok(dishes);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DishViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var dish = await _dishService.GetDishWithIngredients(id);

                if (dish == null)
                    return NotFound();

                return Ok(dish);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
