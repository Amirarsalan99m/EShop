using EShop.Domain.Entities.Access;
using EShop.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Entities.Account
{
    public class User:BaseEntity
    {

        #region Properties

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(100, ErrorMessage="تعداد کارکتر های {0} نمی تواند بیشتر از {1} باشد")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MinLength(8, ErrorMessage = "تعداد کارکتر های {0} نمی تواند کمتر از {1} باشد")]
        public string Password { get; set; }

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

        [MaxLength(100, ErrorMessage = "تعداد کارکتر های {0} نمی تواند بیشتر از {1} باشد")]
        public string EmailActivationCode { get; set; }
        public bool IsActivated { get; set; }

        #endregion

        #region Relations

        public ICollection<UserRole> UserRoles { get; set; }

        #endregion
    }
}
