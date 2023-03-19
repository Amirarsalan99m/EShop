using EShop.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EShop.Domain.Entities.Access
{
    public class Role:BaseEntity
    {

        #region Properties


        [Display(Name = "نام سیستمی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(100, ErrorMessage = "تعداد کارکتر های {0} نمی تواند بیشتر از {1} باشد")]
        public string Name { get; set; }


        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(100, ErrorMessage = "تعداد کارکتر های {0} نمی تواند بیشتر از {1} باشد")]
        public string Title { get; set; }

        #endregion


        #region Relations

        public ICollection<UserRole> UserRoles { get; set; }

        #endregion

    }
}
