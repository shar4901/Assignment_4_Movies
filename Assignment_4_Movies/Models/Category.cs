using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Movies.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int category_id { get; set; }
        [Required]
        public string category_name { get; set; }
    }
}
