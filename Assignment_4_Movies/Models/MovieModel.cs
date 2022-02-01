using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Movies.Models
{
    public class MovieModel
    {
        [Key]
        [Required]
        public int Movie_id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string Lent_to { get; set; }
        [MaxLength (25)]
        public string Notes { get; set; }

        //foreign key
        [Required]
        public int Category_id { get; set; }
        public Category Category { get; set; }
    }
}
