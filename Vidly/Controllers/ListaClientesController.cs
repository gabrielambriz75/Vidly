using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Clientes;

namespace Vidly.Controllers
{
    public class ListaClientesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var listaClientes = new ListaClientes();
            var model = listaClientes.ObtenerClientes();
            return View(model);

        }

        
      
    }
}