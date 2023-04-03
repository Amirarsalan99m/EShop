using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.DTOs.Account
{
    public class LoginUserDTO
    {
        public string Email {get;set;}
        public string Password { get; set; }
    }

    public enum LoginUserResult
    {
        Success,
        IncorrectUsernameOrPassword,
        NotActivated
    }
}
