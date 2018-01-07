using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eReservation.Models.AccountViewModels
{
    public class LoginWith2faViewModel
    {
        [Required(ErrorMessage = "Kod jest wymagany")]
        [StringLength(7, ErrorMessage = "{0} musi mieć minimum {2} znaków oraz być nie dłuższy niż {1} znaków.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Kod Autentykacyjny")]
        public string TwoFactorCode { get; set; }

        [Display(Name = "Zapamiętaj ten komputer")]
        public bool RememberMachine { get; set; }

        public bool RememberMe { get; set; }
    }
}
