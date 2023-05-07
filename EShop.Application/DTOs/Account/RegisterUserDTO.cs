using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.DTOs.Account
{
    public class RegisterUserDTO
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        public string Address { get; set; }
    }

    public enum RegisterUserResult
    {
        Success,
        EmailExists
    }
}
