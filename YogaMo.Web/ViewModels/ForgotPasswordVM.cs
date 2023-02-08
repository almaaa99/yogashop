using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YogaMo.Web.ViewModels
{
    public class ForgotPasswordVM
    {
        [Display(Name = "Email address")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
