using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name="ConfirmPassword")]
        [Compare("Password",ErrorMessage ="please write the same password")]
        public string ConfirmPassword{ get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string City { get; set; }
        public int Age { get; set; }


        public RegisterViewModel()
        {
        }
    }
}
