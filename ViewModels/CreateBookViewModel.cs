using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBooksmvc.ViewModels
{
    public class CreateBookViewModel
    {
        [Required (ErrorMessage ="*Required*")]
        [MinLength(6), MaxLength(50)]
        public string Name{get; set;}
        [Required (ErrorMessage ="*Required*")]
        [MinLength(6), MaxLength(25)]
        public string Genre{get; set;}
        public IFormFile coverImage {get; set;}
    }
}