global using BlazorEcommerce.Shared;
global using System.Net.Http.Json;
global using BlazorEcommerce.Client.Services.ProductService;
global using BlazorEcommerce.Client.Services.CategoryService;
global using BlazorEcommerce.Client.Services.CartService;
global using BlazorEcommerce.Client.Services.AuthService;

using BlazorEcommerce.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;
using BlazorEcommerce.Client.Services.ProductTypeService;
using BlazorEcommerce.Client.Services.AddressService;
using BlazorEcommerce.Client.Services.OrderService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//Various Services
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services
    .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
    .AddScoped<IProductService, ProductService>()
    .AddScoped<ICategoryService, CategoryService>()
    .AddScoped<ICartService, CartService>()
    .AddScoped<IOrderService, OrderService>()
    .AddScoped<IAddressService, AddressService>()
    .AddScoped<IProductTypeService, ProductTypeService>();

//The following are for authentication and authorization
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

await builder.Build().RunAsync();
