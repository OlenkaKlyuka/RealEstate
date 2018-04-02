﻿using System.ComponentModel.DataAnnotations;

namespace RealEststate.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords aren't indentical")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string PasswordConfirm { get; set; }
    }
}