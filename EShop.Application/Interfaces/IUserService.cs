using EShop.Application.DTOs.Account;
using EShop.Domain.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<List<User>> GetAllUsers();
        Task<RegisterUserResult> RegisterUser(RegisterUserDTO register);
        Task<LoginUserResult> LoginUser(LoginUserDTO login);
        Task<User> GetUserByEmail(string email);
        bool IsEmailExists(string email);
    }
}
