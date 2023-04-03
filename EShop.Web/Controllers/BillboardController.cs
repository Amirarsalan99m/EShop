using EShop.Application.Interfaces;
using EShop.Application.Models;
using EShop.Application.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.AspNetCore.RateLimiting;
using System.Text.Json;

namespace EShop.Web.Controllers
{
    [EnableRateLimiting("fixed")]
    public class BillboardController:BaseApiController
    {
        private IBillboardService _billboardService;

        public BillboardController(IBillboardService billboardService)
        {
            _billboardService = billboardService;
        }

        [HttpGet("GetBillboardItems")]
        public async Task<ActionResult<ActionResult<List<BillboardModel>>>> GetBillboardItems()
        {
            var billboardItems = await _billboardService.GetBillboardItems();
            return Ok(new { billboardItems });
        }

        [HttpGet("GetRandom")]
        [OutputCache(Duration =1000)]
        public int GetRandom()
        {
            var random = new Random();
            return random.Next();
        }
    }
}