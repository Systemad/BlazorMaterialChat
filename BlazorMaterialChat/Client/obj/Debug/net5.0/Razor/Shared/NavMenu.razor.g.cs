#pragma checksum "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38cc8d4b275434fe68e7fde4d1240ba61e5530a9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMaterialChat.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using BlazorMaterialChat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using BlazorMaterialChat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(2);
                __builder2.AddAttribute(3, "Href", "");
                __builder2.AddAttribute(4, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 2 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\Shared\NavMenu.razor"
                               NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\Shared\NavMenu.razor"
                                                        Icons.Material.Filled.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(7, "Home");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(9);
                __builder2.AddAttribute(10, "Href", "/counter");
                __builder2.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\Shared\NavMenu.razor"
                                       NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\Shared\NavMenu.razor"
                                                                   Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Counter");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(16);
                __builder2.AddAttribute(17, "Href", "/fetchdata");
                __builder2.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\Shared\NavMenu.razor"
                                         NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\Users\Dan\source\repos\BlazorMaterialChat\BlazorMaterialChat\Client\Shared\NavMenu.razor"
                                                                     Icons.Material.Filled.List

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(21, "Fetch data");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
