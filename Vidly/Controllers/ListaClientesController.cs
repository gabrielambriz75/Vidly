﻿using System;
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
           
            return View();

        }

        public ViewResult Detalle(int id)
        { 
            var cliente = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            return View(cliente);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel()
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm",viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()

                };
                

                return View("CustomerForm",viewmodel);
            }

            if(customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
               var customerInDb =  _context.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.Birthday = customer.Birthday;
                customerInDb.MembershipType = customer.MembershipType;
                customerInDb.IsSuscribedToNewsletter = customer.IsSuscribedToNewsletter;

            }

           
            _context.SaveChanges();

            return RedirectToAction("Index","ListaClientes");
        }


        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }

    }
}