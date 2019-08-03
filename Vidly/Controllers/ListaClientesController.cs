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
        public ViewResult Index()
        {
            var listaClientes = new ListaClientes();
            var model = listaClientes.ObtenerClientes();
            return View(model);

            

        }

        public ActionResult Detalle(int id)
        {
            var listaCliente = new ListaClientes();
            var cliente = listaCliente.ObtenerClientes().SingleOrDefault(c => c.Id == id);

            return View(cliente);
        }

        
      
    }
}