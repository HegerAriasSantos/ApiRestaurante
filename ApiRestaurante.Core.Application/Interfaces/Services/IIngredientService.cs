using ApiRestaurante.Core.Application.DTOs.User;
using ApiRestaurante.Core.Application.ViewModels.Dish;
using ApiRestaurante.Core.Application.ViewModels.Ingredient;
using ApiRestaurante.Core.Domain.Entities;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IIngredientService : IGenericService<Ingredient, IngredientViewModel, SaveIngredientViewModel>
    {
        
    }
}