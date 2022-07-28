using ApiRestaurante.Core.Application.DTOs.User;
using ApiRestaurante.Core.Application.ViewModels.Dish;
using ApiRestaurante.Core.Application.ViewModels.Order;
using ApiRestaurante.Core.Domain.Entities;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IOrderService : IGenericService<Order, OrderViewModel, SaveOrderViewModel>
    {
        
    }
}