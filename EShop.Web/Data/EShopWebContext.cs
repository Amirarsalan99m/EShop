using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EShop.Domain.Entities;

namespace EShop.Web.Data
{
    public class EShopWebContext : DbContext
    {
        public EShopWebContext (DbContextOptions<EShopWebContext> options)
            : base(options)
        {
        }

        public DbSet<EShop.Domain.Entities.Book> Book { get; set; } = default!;
    }
}
