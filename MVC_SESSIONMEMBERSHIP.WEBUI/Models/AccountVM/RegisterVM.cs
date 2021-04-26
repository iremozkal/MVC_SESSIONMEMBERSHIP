using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_SESSIONMEMBERSHIP.WEBUI.Models.AccountVM
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "First Name and Last Name are required!")]
        [MaxLength(50, ErrorMessage = "More than 50 characters cannot be entered!")]
        [Display(Name = "Name Surname")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Email address is not valid!")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is required!")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords don't match!")]
        public string ConfirmPassword { get; set; }
    }
}