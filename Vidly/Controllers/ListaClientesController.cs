using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;


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
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);

        }

        public ViewResult Detalle(int id)
        { 
            var cliente = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            return View(cliente);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }
        
      
    }
}