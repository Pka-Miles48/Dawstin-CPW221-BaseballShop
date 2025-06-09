using Dawstin_CPW221_BaseballShop.Baseball_Data;
using Dawstin_CPW221_BaseballShop.Models;
using Dawstin_CPW221_BaseballShop.Repositories;
using Dawstin_CPW221_BaseballShop.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register database context using SQL Server connection string
builder.Services.AddDbContext<BaseballShop>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BaseballShop")));

// Enable developer-friendly error pages for database-related issues
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add MVC controllers with views
builder.Services.AddControllersWithViews();

// Register an instance of IHttpContextAccessor for session and context-related operations
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// Enable session support to persist cart data across requests
builder.Services.AddSession();

// Configure ASP.NET Core Identity for authentication
builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    // Allows users to sign in without email confirmation (modify if needed)
    options.SignIn.RequireConfirmedAccount = false;
})
    // Store user accounts in the BaseballShop database using Entity Framework
    .AddEntityFrameworkStores<BaseballShop>();

// Register authentication and authorization services
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

// Register scoped services and repositories for dependency injection
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<MockPaymentService>();

var app = builder.Build();

// Configure the request pipeline

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Custom error page for production
    app.UseHsts(); // Enable HSTS for enhanced security
}

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseStaticFiles(); // Serve static files (CSS, JS, images, etc.)

app.UseRouting(); // Middleware for handling routing

app.UseAuthentication(); // Ensure authentication middleware is applied first
app.UseAuthorization();  // Authorization middleware should come after routing

app.UseSession(); // Activate session handling for cart functionality

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Enable endpoint mapping for controllers
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Default route configuration

app.Run(); // Start the application