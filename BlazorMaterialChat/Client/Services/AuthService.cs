using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorMaterialChat.Shared.Models;

namespace BlazorMaterialChat.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Login(LoginRequest loginRequest)
        {
            
            var result = await _httpClient.PostAsJsonAsync("api/auth/login", loginRequest);
            if (result.StatusCode == HttpStatusCode.BadRequest)
                throw new Exception(await result.Content.ReadAsStringAsync());
        }

        public async Task Register(RegisterRequest registerRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/register", registerRequest);
            if (result.StatusCode == HttpStatusCode.BadRequest)
                throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task Logout()
        {
            var result = await _httpClient.PostAsync("api/auth/logout", null!);
            result.EnsureSuccessStatusCode();
        }

        public async Task<CurrentUser> CurrentUserInfo()
        {
            var result = await _httpClient.GetFromJsonAsync<CurrentUser>("api/auth/currentuserinfo");
            return result;
        }
    }
}