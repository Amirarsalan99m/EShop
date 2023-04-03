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
    public class BookService : IBookService
    {
        private IGenericRepository<Book> _repository;

        public BookService(IGenericRepository<Book> repository)
        {
            _repository = repository;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _repository.GetEntitiesQuery().ToListAsync();
        }
    }
}
