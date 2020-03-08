using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Vidly.Models;
using Vidly.ViewModels;

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
        
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");
            //var movie = _context.Movies.Include(x => x.GenreType).ToList();
            else
                return View("ReadOnlyList");
        }

        //public ViewResult Detalle(int id)
        //{
        //    var movie = _context.Movies.Include(x => x.GenreType).FirstOrDefault(c => c.Id == id);
        //    return View(movie);
        //}

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null)
            {
                HttpNotFound();
            }

            var viewModel = new MovieFormViewModel(movie)
            {
             
                GenreTypes = _context.GenreTypes.ToList()
            };

            return View("Detalle", viewModel);
        }



        public ActionResult New()
        {
            var genreTypes = _context.GenreTypes.ToList();

            var viewModel = new MovieFormViewModel
            {
                
                GenreTypes = genreTypes
            };

            return View("New", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var modelview = new MovieFormViewModel(movie)
                {
                    
                    GenreTypes = _context.GenreTypes.ToList()
                };

                return View("New", modelview);

            }

            if (movie.Id == 0)

            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);

            }
            else
            {
                var movieInDb = _context.Movies.Single(x => x.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreTypeId = movie.GenreTypeId;
                movieInDb.NumberStock = movie.NumberStock;


            }
            _context.SaveChanges();
            return RedirectToAction("Index", "ListaPeliculas");

        }


    }
}