using System.ComponentModel.DataAnnotations;

namespace EShop.Domain.Entities
{
    public class BookCategory
    {
        [Key]
        public long Id { get; set; }
        public long BookId { get; set; }
        public long CategoryId { get; set; }
        public Book Book { get; set; }
        public Category Category { get; set; }
    }
}
