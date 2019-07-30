using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Peliculas;

namespace Vidly.Controllers
{
    public class ListaPeliculasController : Controller
    {
        // GET: ListaPeliculas
        public ActionResult Index()
        {
            var listaPeliculas = new ListaPeliculas();
            var model = listaPeliculas.ObtenerPeliculas();

            return View(model);
        }
    }
}