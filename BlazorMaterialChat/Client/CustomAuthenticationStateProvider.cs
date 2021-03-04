using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;
using BlazorMaterialChat.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;


namespace BlazorMaterialChat.Client
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;

        public CustomAuthenticationStateProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            User currentUser = await _httpClient.GetFromJsonAsync<User>("user/getcurrentuser");

            if (currentUser != null && currentUser.Username != null)
            {
                // create claim
                var claim = new Claim(ClaimTypes.Name, currentUser.Username);
                
                // create claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] {claim}, "serverAuth");
                
                // create claimsPrincipal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                return new AuthenticationState(claimsPrincipal);
            }
            else
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
        }
    }
}