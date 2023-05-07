using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBooksmvc.Models
{
    public class Genre
    {
        [Required (ErrorMessage ="*Required*")]
       public int Id{get; set;}
       
       [Required(ErrorMessage ="*Required*")]
       [MinLength(6 ,ErrorMessage ="*Minimum of 6 characters"), MaxLength(25, ErrorMessage ="*Maximum of 25 characters")]
        public string Name{get; set;}
        public List<Book> ListOfBooks = new List<Book>();
    
        
    }
}