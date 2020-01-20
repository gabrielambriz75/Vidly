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

        [Required]
        public string Name { get; set; }

        public GenreType GenreType { get; set; }

        [Display(Name = "Genre Type")]
       
        public byte GenreTypeId { get; set; }

        [Display(Name = "Release Date")]
        [Required]

        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public int NumberStock { get; set; }


    }
}