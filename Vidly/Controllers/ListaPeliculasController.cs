using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class ListaPeliculasController : Controller
    {
        // GET: ListaPeliculas
        private ApplicationDbContext _context;
        public ListaPeliculasController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var movie = _context.Movies.ToList();

            return View(movie);
        }

        public ViewResult Detalle(int id)
        {
            var movie = _context.Movies.FirstOrDefault(c => c.Id == id);
            return View(movie);
        }
    }
}