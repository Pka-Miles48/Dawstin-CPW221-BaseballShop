using Dawstin_CPW221_BaseballShop.Baseball_Data;
using Dawstin_CPW221_BaseballShop.Models;
using Dawstin_CPW221_BaseballShop.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BaseballShop>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Maps the default controller route, enabling conventional routing in ASP.NET Core.
app.MapDefaultControllerRoute();

// Registers an instance of IHttpContextAccessor as a singleton,
// allowing access to HTTP context-related data (like sessions) across the application.
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// Adds the ShoppingCartService as a scoped service.
// This ensures each request gets a unique instance, ideal for session-based shopping carts.
builder.Services.AddScoped<ShoppingCartService>();

// Enables session support within the application.
// This is required to store cart items persistently across different requests.
builder.Services.AddSession();

// Activates session handling middleware to manage user sessions.
app.UseSession();

// Configures ASP.NET Core Identity with default settings.
// The ApplicationUser class represents the user entity.
builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    // Specifies whether users must confirm their email before signing in.
    // Set to 'true' if email confirmation is required for account activation.
    options.SignIn.RequireConfirmedAccount = false;
})
    // Uses Entity Framework to store user data in the BaseballShop database.
    .AddEntityFrameworkStores<BaseballShop>();

// Enables authentication services to validate user credentials.
builder.Services.AddAuthentication();

// Enables authorization services to manage access control (roles & policies).
builder.Services.AddAuthorization();

// Applies authentication middleware to enforce user login.
app.UseAuthentication();

// Applies authorization middleware to restrict access based on user roles and policies.
app.UseAuthorization();
