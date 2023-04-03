
using EShop.Application.Interfaces;
using EShop.Application.Security;
using EShop.Application.Services;
using EShop.Domain.Interfaces;
using EShop.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Generic Repository
            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            service.AddScoped<IUserService, UserService>();

            service.AddScoped<IBookService, BookService>();

            service.AddScoped<IBillboardService, BillboardService>();

            service.AddScoped<IPasswordHelper, PasswordHelper>();

            //service.AddSingleton<AggressionScore>();
        }
    }
}
