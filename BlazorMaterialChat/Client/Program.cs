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
using BlazorMaterialChat.Client.Services;
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
            
            // Authentication
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<CustomStateProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider>(
                s => s.GetRequiredService<CustomStateProvider>());
            builder.Services.AddScoped<IAuthService, AuthService>();
            
            // MudBlazor
            builder.Services.AddMudServices();
            
            builder.Services.AddTransient(sp => 
                new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
