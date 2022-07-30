using ApiRestaurante.Core.Application.ViewModels.Order;
using ApiRestaurante.Core.Application.ViewModels.OrderDish;
using ApiRestaurante.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IOrderService : IGenericService<Order, OrderViewModel, SaveOrderViewModel>
    {
        Task<List<OrderViewModel>> GetOrdersByTable(int tableId);
        Task AddDishToOrder(int orderId, int dishId);
        Task<List<OrderDishViewModel>> GetAllDishesIdsByOrder(int orderId);
        Task DeleteDishFromOrder(int orderId, int dishId);
        Task<OrderViewModel> GetOrderWithDishes(int id);
        Task<List<OrderViewModel>> GetAllWithDishes();
    }
}