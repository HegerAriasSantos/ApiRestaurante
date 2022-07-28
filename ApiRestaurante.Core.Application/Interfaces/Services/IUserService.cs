using ApiRestaurante.Core.Application.DTOs.User;
using ApiRestaurante.Core.Application.ViewModels.User;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<RegisterResponse> AddAdmin(SaveUserViewModel saveViewModel);
        Task<RegisterResponse> AddWaiter(SaveUserViewModel saveViewModel);
        Task<LoginResponse> Login(LoginViewModel login);
    }
}