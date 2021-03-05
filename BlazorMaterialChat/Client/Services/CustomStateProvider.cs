using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BlazorMaterialChat.Shared.Models;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorMaterialChat.Client.Services
{
    public class CustomStateProvider : AuthenticationStateProvider
    {
        private readonly IAuthService _api;
        private CurrentUser _currentUser;

        public CustomStateProvider(IAuthService api)
        {
            this._api = api;
        }
        
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            try
            {
                var userInfo = await GetCurrentUser();
                if (userInfo.IsAuthenticated)
                {
                    var claims = new[]
                    {
                        new Claim(ClaimTypes.Name, _currentUser.UserName)}
                        .Concat(_currentUser.Claims
                        .Select(c => new Claim(c.Key, c.Value)));
                    identity = new ClaimsIdentity(claims, "Server authentication");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request failed:" + ex.ToString());
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }

        private async Task<CurrentUser> GetCurrentUser()
        {
            if (_currentUser != null && _currentUser.IsAuthenticated) return _currentUser;
            _currentUser = await _api.CurrentUserInfo();
            return _currentUser;
        }

        public async Task Logout()
        {
            await _api.Logout();
            _currentUser = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public async Task Login(LoginRequest loginRequest)
        {
            await _api.Login(loginRequest);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task Register(RegisterRequest registerRequest)
        {
            await _api.Register(registerRequest);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}