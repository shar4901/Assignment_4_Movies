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
        public int movid_id { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }
        [Required]
        public bool edited { get; set; }
        public string lent_to { get; set; }
        [MaxLength (25)]
        public string notes { get; set; }
    }
}
