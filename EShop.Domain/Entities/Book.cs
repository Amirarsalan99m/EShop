using EShop.Domain.Entities.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities
{
    public class Book:BaseEntity
    {
        public required string Title { get; set; }
        public string? Shabak { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime Release_Date { get; set; }
        public int Price { get; set; }
        public long? PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }

        public ICollection<BookCategory> CategoriesLink { get; set; }

    }
}
