using ApiRestaurante.Core.Application.ViewModels.Order;
using ApiRestaurante.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IOrderService : IGenericService<Order, OrderViewModel, SaveOrderViewModel>
    {
        Task<List<OrderViewModel>> GetOrdersByTable(int tableId);
    }
}