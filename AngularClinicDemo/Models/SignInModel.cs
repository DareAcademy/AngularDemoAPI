﻿using System.ComponentModel.DataAnnotations;

namespace AngularClinicDemo.Models
{
    public class SignInModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
