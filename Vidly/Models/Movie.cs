using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public GenreType GenreType { get; set; }

        [Display(Name = "Genre Type")]
        [Required]
        public byte GenreTypeId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Display(Name= "Number in Stock")]
        public int NumberStock { get; set; }


    }
}