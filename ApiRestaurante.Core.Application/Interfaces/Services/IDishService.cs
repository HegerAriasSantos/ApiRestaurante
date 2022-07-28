using ApiRestaurante.Core.Application.DTOs.User;
using ApiRestaurante.Core.Application.ViewModels.Dish;
using ApiRestaurante.Core.Domain.Entities;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IDishService : IGenericService<Dish, DishViewModel, SaveDishViewModel>
    {
        
    }
}