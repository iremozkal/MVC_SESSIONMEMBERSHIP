using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_SESSIONMEMBERSHIP.WEBUI.Models.AccountVM
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Email address is not valid!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}