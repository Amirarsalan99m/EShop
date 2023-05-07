using EShop.Application.Interfaces;
using EShop.Application.Models;
using EShop.Domain.Entities;
using EShop.Domain.Interfaces;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Services
{
    public class BillboardService : IBillboardService
    {
        private IGenericRepository<Book> _repository;
        public BillboardService(IGenericRepository<Book> repository)
        {
            _repository = repository;
        }

        public async Task<List<BillboardModel>> GetBillboardItems()
        {
            var books = await _repository.GetEntitiesQuery().Take(5).ToListAsync();
            var billboardItems = new List<BillboardModel>();
            foreach (var book in books)
            {
                var billboardItem = new BillboardModel()
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                    Image = book.Image,
                };

                billboardItems.Add(billboardItem);
            }
            return billboardItems;
        }
}
}
