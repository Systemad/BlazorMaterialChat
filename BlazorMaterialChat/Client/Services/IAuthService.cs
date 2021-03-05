using System.Threading.Tasks;
using BlazorMaterialChat.Shared.Models;

namespace BlazorMaterialChat.Client.Services
{
    public interface IAuthService
    {
        Task Login(LoginRequest loginRequest);
        Task Register(RegisterRequest registerRequest);
        Task Logout();
        Task<CurrentUser> CurrentUserInfo();
    }
} 