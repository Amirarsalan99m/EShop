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
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(100, ErrorMessage = "تعداد کارکتر های {0} نمی تواند بیشتر از {1} باشد")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(8, ErrorMessage = "تعداد کارکتر های {0} نمی تواند کمتر از {1} باشد")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(8, ErrorMessage = "تعداد کارکتر های {0} نمی تواند کمتر از {1} باشد")]
        [Compare("Password", ErrorMessage = "کلمه عبور و تکرار باید یکی باشد")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(100, ErrorMessage = "تعداد کارکتر های {0} نمی تواند بیشتر از {1} باشد")]
        public string FirstName { get; set; }


        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(100, ErrorMessage = "تعداد کارکتر های {0} نمی تواند بیشتر از {1} باشد")]
        public string LastName { get; set; }


        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(500, ErrorMessage = "تعداد کارکتر های {0} نمی تواند بیشتر از {1} باشد")]
        public string Address { get; set; }
    }

    public enum RegisterUserResult
    {
        Success,
        EmailExists
    }
}
