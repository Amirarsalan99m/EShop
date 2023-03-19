using EShop.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EShop.Application.Utils.Extensions.Connection
{
    public static class ConnectionExtension
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<EShopDbContext>(options =>
            {
                var connectionString = "ConnectionStrings:EShopConnection:Development";
                options.UseSqlServer(configuration[connectionString]);
            });

            return service;

        }
    }
}
