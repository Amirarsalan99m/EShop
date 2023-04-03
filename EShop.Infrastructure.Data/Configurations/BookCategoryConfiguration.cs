using EShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.Data.Configurations
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            //Make Both BookId and CategoryId Primary Key
            builder.HasOne(x => x.Category).WithMany(b => b.BooksLink).HasForeignKey(cf => cf.CategoryId);
            builder.HasOne(x => x.Book).WithMany(b => b.CategoriesLink).HasForeignKey(bf => bf.BookId);

            #region Seed Data BookCategory

            builder.HasData(
                new BookCategory
                {
                    Id = 1,
                    BookId = 1,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 2,
                    BookId = 2,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 3,
                    BookId = 3,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 4,
                    BookId = 4,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 5,
                    BookId = 5,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 6,
                    BookId = 6,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 7,
                    BookId = 7,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 8,
                    BookId = 8,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 9,
                    BookId = 9,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 10,
                    BookId = 10,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 11,
                    BookId = 11,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 12,
                    BookId = 12,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 13,
                    BookId = 13,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 14,
                    BookId = 14,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 15,
                    BookId = 15,
                    CategoryId = 1
                },
                new BookCategory
                {
                    Id = 16,
                    BookId = 16,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 17,
                    BookId = 17,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 18,
                    BookId = 18,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 19,
                    BookId = 19,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 20,
                    BookId = 20,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 21,
                    BookId = 21,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 22,
                    BookId = 22,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 23,
                    BookId = 23,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 24,
                    BookId = 24,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 25,
                    BookId = 25,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 26,
                    BookId = 26,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 27,
                    BookId = 27,
                    CategoryId = 2
                },
                new BookCategory
                {
                    Id = 28,
                    BookId = 28,
                    CategoryId = 3
                },
                new BookCategory
                {
                    Id = 29,
                    BookId = 29,
                    CategoryId = 3
                },
                new BookCategory
                {
                    Id = 30,
                    BookId = 30,
                    CategoryId = 3
                },
                new BookCategory
                {
                    Id = 31,
                    BookId = 31,
                    CategoryId = 3
                },
                new BookCategory
                {
                    Id = 32,
                    BookId = 32,
                    CategoryId = 3
                },
                new BookCategory
                {
                    Id = 33,
                    BookId = 33,
                    CategoryId = 3
                },
                new BookCategory
                {
                    Id = 34,
                    BookId = 34,
                    CategoryId = 3
                },
                new BookCategory
                {
                    Id = 35,
                    BookId = 35,
                    CategoryId = 3
                },
                new BookCategory
                {
                    Id = 36,
                    BookId = 36,
                    CategoryId = 3
                },
                new BookCategory
                {
                    Id = 37,
                    BookId = 37,
                    CategoryId = 3
                },
                new BookCategory
                {
                    Id = 38,
                    BookId = 38,
                    CategoryId = 4
                },
                new BookCategory
                {
                    Id = 39,
                    BookId = 39,
                    CategoryId = 4
                },
                new BookCategory
                {
                    Id = 40,
                    BookId = 40,
                    CategoryId = 4
                },
                new BookCategory
                {
                    Id = 41,
                    BookId = 41,
                    CategoryId = 4
                },
                new BookCategory
                {
                    Id = 42,
                    BookId = 42,
                    CategoryId = 4
                },
                new BookCategory
                {
                    Id = 43,
                    BookId = 43,
                    CategoryId = 5
                },
                new BookCategory
                {
                    Id = 44,
                    BookId = 44,
                    CategoryId = 5
                },
                new BookCategory
                {
                    Id = 45,
                    BookId = 45,
                    CategoryId = 5
                },
                new BookCategory
                {
                    Id = 46,
                    BookId = 46,
                    CategoryId = 5
                },
                new BookCategory
                {
                    Id = 47,
                    BookId = 47,
                    CategoryId = 5
                },
                new BookCategory
                {
                    Id = 48,
                    BookId = 48,
                    CategoryId = 6
                },
                new BookCategory
                {
                    Id = 49,
                    BookId = 49,
                    CategoryId = 6
                },
                new BookCategory
                {
                    Id = 50,
                    BookId = 50,
                    CategoryId = 6
                },
                new BookCategory
                {
                    Id = 51,
                    BookId = 51,
                    CategoryId = 6
                },
                new BookCategory
                {
                    Id = 52,
                    BookId = 52,
                    CategoryId = 6
                }
            );
            #endregion
        }
    }
}
