using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week6_MovieRegistration1.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(30), Required]
        public string Title { get; set; }
        public string Genre { get; set; }
        [Range(1880, 2021)]
        public int Year { get; set; }
        public int Runtime { get; set; }

    }
}