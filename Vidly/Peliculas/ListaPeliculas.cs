using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Peliculas
{
    public class ListaPeliculas
    {
        public Movie ObtenerPeliculas()
        {
            return new Movie()
            {
                Name = "Avengers EndGame"
            };
        }
    }
}