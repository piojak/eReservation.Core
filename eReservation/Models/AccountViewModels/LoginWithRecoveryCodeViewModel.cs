using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eReservation.Models.AccountViewModels
{
    public class LoginWithRecoveryCodeViewModel
    {
            [Required(ErrorMessage = "Kod jest wymagany")]
            [DataType(DataType.Text)]
            [Display(Name = "Ko odzyskiwania")]
            public string RecoveryCode { get; set; }
    }
}
