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
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Add a valid title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Add a valid year")]
        [Range(1800, 2100)]
        public int Year { get; set; }
        [Required(ErrorMessage = "Add a valid director")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Add a valid rating")]
        public string Rating { get; set; }
        [Required(ErrorMessage = "Add a valid edited option")]
        public bool Edited { get; set; }
        public string Lent_to { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

        //foreign key
        [Required(ErrorMessage = "Add a valid category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
