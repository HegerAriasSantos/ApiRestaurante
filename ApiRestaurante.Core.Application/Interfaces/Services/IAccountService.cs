using ApiRestaurante.Core.Application.DTOs.User;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IAccountService
    {
        Task<LoginResponse> LoginAsync(LoginRequest request);
        Task<RegisterResponse> RegisterAdminAsync(RegisterRequest request);
        Task<RegisterResponse> RegisterWaiterAsync(RegisterRequest request);
    }
}