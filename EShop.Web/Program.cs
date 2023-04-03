using EShop.Application.Utils.Extensions.Connection;
using EShop.Infrastructure.IoC;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Threading.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EShop.Web;
using Microsoft.Extensions.ML;
using EShop.AggressionScoreConsole;
using EShop.Web.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EShopWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EShopWebContext") ?? throw new InvalidOperationException("Connection string 'EShopWebContext' not found.")));

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IConfiguration>(
    new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile($"appsettings.json")
    .Build()
    );

#region DbContext and Services

builder.Services.AddApplicationDbContext(builder.Configuration);
DependencyContainer.RegisterServices(builder.Services);

#endregion

builder.Services.AddCors(options =>
{
    options.AddPolicy("EnableCors", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod()
        .Build();
    });
});

builder.Services.AddRateLimiter(_ => _
    .AddFixedWindowLimiter(policyName: "fixed", options =>
    {
        options.PermitLimit = 100;
        options.Window = TimeSpan.FromSeconds(12);
        options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        options.QueueLimit = 2;
    }));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuer = true, 
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "https://localhost:5001/",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("EshopJWTBearer"))
        };
    });

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddAggressionScoreConsolePredictionEnginePool();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseCors("EnableCors");
app.UseAuthentication();

app.UseRouting();

app.UseRateLimiter();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();

