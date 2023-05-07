using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBooksmvc.Models
{
    public class Book
    {
        [Required (ErrorMessage ="*Required*")]
        public int Id{get; set;}
       
        public string Name{get; set;}
        public bool IsAvailable{get; set;} = true;
        public string Genre{get; set;}
        public string coverImagePath {get; set;}

        
    }
}