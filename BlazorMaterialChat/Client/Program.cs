using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Http;
using System.Threading.Tasks;
using BlazorMaterialChat.Client.ViewModels;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;

namespace BlazorMaterialChat.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddMudServices();
            
            // AddScoped
            builder.Services.AddScoped(sp => 
                new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            builder.Services.AddHttpClient<IProfileViewModel, ProfileViewModel>
                ("BlazingChatClient", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
            
            builder.Services.AddHttpClient<ILoginViewModel, LoginViewModel>
                ("BlazorMaterialChat", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

            builder.Services.AddScoped<AuthenticationStateProvider,CustomAuthenticationStateProvider>();
            
            await builder.Build().RunAsync();
        }
    }
}
