using ApiRestaurante.Core.Application.DTOs.User;
using ApiRestaurante.Core.Application.ViewModels.Dish;
using ApiRestaurante.Core.Application.ViewModels.Table;
using ApiRestaurante.Core.Domain.Entities;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface ITableService : IGenericService<Table, TableViewModel, SaveTableViewModel>
    {
        
    }
}