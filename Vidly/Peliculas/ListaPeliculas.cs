using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Peliculas
{
    public class ListaPeliculas
    {
        public List<Movie> ObtenerPeliculas()
        {
            var pelicula1 = new Movie()
            {
                Id =  1,
                Name = "IT Chapter 2"
            };

            var pelicula2 = new Movie()
            {
                Id = 2,
                Name = "Avengers End Game"
            };
            var pelicula3 = new Movie()
            {
                Id = 3,
                Name = "Matrix"
            };
            
            return new List<Movie>{ pelicula1, pelicula2, pelicula3};

        }
    }
}