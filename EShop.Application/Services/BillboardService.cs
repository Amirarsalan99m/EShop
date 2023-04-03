using EShop.Application.Interfaces;
using EShop.Application.Models;
using EShop.Domain.Entities;
using EShop.Domain.Interfaces;
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
            var books = await _repository.GetEntitiesQuery().Take(2).ToListAsync();
            var billboardItems = new List<BillboardModel>()
            {
                new BillboardModel()
                {
                    Id = books[0].Id,
                    Title = books[0].Title,
                    Description = books[0].Description,
                    Image = books[0].Image,
                },
                new BillboardModel()
                {
                    Id = books[1].Id,
                    Title = books[1].Title,
                    Description = books[1].Description,
                    Image = books[1].Image,
                }
            };

            return billboardItems;
        }
    }
}
