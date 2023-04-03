using EShop.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities
{
    public class Publisher:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Establishment_Date { get; set; }
        public List<Book> Books { get; set; }
    }
}
