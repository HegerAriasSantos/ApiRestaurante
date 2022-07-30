using ApiRestaurante.Core.Application.DTOs.User;
using ApiRestaurante.Core.Application.ViewModels.Dish;
using ApiRestaurante.Core.Application.ViewModels.Ingredient;
using ApiRestaurante.Core.Application.ViewModels.IngredientDish;
using ApiRestaurante.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IDishService : IGenericService<Dish, DishViewModel, SaveDishViewModel>
    {
        Task DeleteIngredientFromDish(int ingId, int dishId);
        Task AddIngredientToDish(int dishId, int ingId);
        Task<DishViewModel> GetDishWithIngredients(int id);
        Task<List<DishViewModel>> GetAllWithIngredients();
        Task<List<IngredientDishViewModel>> GetAllIngredientIdsByDish(int dishId);
        Task<double> GetPriceById(int id);
    }
}