global using Microsoft.EntityFrameworkCore;
global using BlazorEcommerce.Server.Data;
global using BlazorEcommerce.Server.Repositories.ProductRepository;
global using BlazorEcommerce.Server.Repositories.CategoryRepository;
global using BlazorEcommerce.Server.Repositories.CartRepository;
global using BlazorEcommerce.Server.Services.ProductService;
global using BlazorEcommerce.Server.Services.CategoryService;
global using BlazorEcommerce.Server.Services.CartService;
global using BlazorEcommerce.Server.Services.AuthService;
global using BlazorEcommerce.Server.Services.AddressService;
global using BlazorEcommerce.Server.Services.OrderService;
global using BlazorEcommerce.Server.Services.ProductTypeService;
global using BlazorEcommerce.Server.Services.PaymentService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//SWAGGER: Swagger capabilities (see also below UseSwaggerUI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Various services
builder.Services
    .AddScoped<IProductRepository, ProductRepository>()
    .AddScoped<IProductService, ProductService>()
    .AddScoped<ICategoryRepository, CategoryRepository>()
    .AddScoped<ICategoryService, CategoryService>()
    .AddScoped<ICartRepository, CartRepository>()
    .AddScoped<ICartService, CartService>()
    .AddScoped<IOrderService, OrderService>()
    .AddScoped<IAddressService, AddressService>()
    .AddScoped<IPaymentService, PaymentService>()
    .AddScoped<IProductTypeService, ProductTypeService>();

//Auth services (see also below UseAuthentication, UseAuthorization)
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey =
                new SymmetricSecurityKey(System.Text.Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IAuthService, AuthService>();


var app = builder.Build();

//SWAGGER: See also above
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//SWAGGER: See also above
app.UseSwagger();

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

//In combination with above AddAuthentication...
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
