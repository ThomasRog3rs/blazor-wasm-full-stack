using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattles.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Please enter a username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter a password")]
        [MinLength(8, ErrorMessage = "Your password must be at least 8 characters long")]
        public string Password { get; set; }
    }
}
