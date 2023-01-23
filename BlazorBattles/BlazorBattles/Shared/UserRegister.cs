using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattles.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a username")]
        [MaxLength(16, ErrorMessage = "Your username must not be over 16 characters")]
        public string Username { get; set; }

        public string Bio { get; set; }

        [Required(ErrorMessage = "Please enter a strong password")]
        [MinLength(8, ErrorMessage = "Please enter a password with at least 8 characters")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage = "The passwords do not match")]
        public string ConfirmPassword { get; set; }

        public int StartUnitId { get; set; } = 1;

        [Range(0,1000, ErrorMessage = "Please select a number between 0 and 1000")]
        public int Bananas { get; set; } = 100;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        [Range(typeof(bool), "true", "true", ErrorMessage = "Please accept the terms and conditions to play")]
        public bool TermsAccepted { get; set; } = false;
    }
}
