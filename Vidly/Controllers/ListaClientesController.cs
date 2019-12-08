using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class ListaClientesController : Controller
    {
        // GET: Movies/Random
        private ApplicationDbContext _context;
        public ListaClientesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
           
            var customers = _context.Customers.ToList();

            return View(customers);

        }

        public ActionResult Detalle(int id)
        {
         
            
            var cliente = _context.Customers.SingleOrDefault(c => c.Id == id);
           
                return View(cliente);
            
          
        }

        
      
    }
}