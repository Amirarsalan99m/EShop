using EShop.Domain.Entities;
using EShop.Domain.Entities.Access;
using EShop.Domain.Entities.Account;
using EShop.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure.Data.Context
{
    public class EShopDbContext : DbContext
    {

        #region Constractor

        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {
        }

        #endregion

        #region DbSets

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }

        #endregion

        #region Disable Cascade Delete

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding Database
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookCategoryConfiguration());

            var cascade = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t=>t.GetForeignKeys())
                .Where(fk=>fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascade)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }


            base.OnModelCreating(modelBuilder);
        }

        #endregion

    }
}
