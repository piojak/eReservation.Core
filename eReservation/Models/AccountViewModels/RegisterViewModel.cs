﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eReservation.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email jest wymagany")]
        [EmailAddress(ErrorMessage = "Adres jest nieprawidłowy")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Musisz podać hasło")]
        [StringLength(100, ErrorMessage = "{0} musi mieć minimum {2} znaków oraz być nie dłuższy niż {1} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Hasło i jego potwierdzenie nie są zgodne.")]
        public string ConfirmPassword { get; set; }
    }
}
