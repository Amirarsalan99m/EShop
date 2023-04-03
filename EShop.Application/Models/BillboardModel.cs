using Microsoft.AspNetCore.Http;

namespace EShop.Application.Models
{
    public class BillboardModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
