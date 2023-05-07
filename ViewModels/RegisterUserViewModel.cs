using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BulkyBooksmvc.Models.Enums;

namespace BulkyBooksmvc.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required]
        public string Email {get; set;}
        [MinLength(6), MaxLength(25)]
        public string UserName {get; set;}
        [Required]
        public string PassWord {get; set;}
        [Required]
        public Gender Gender {get; set;}
    }
}