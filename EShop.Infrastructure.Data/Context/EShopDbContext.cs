using EShop.Domain.Entities.Access;
using EShop.Domain.Entities.Account;
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

        #endregion

        #region Disable Cascade Delete

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
