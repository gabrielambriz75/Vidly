using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
namespace Vidly.Clientes
{
    public class ListaClientes
    {
        public List<Customer> ObtenerClientes()
        {
            var usuario1 = new Customer()
            {
                Id = 1,
                Name = "Gabriel Ambriz"
            };

            var usuriario2 = new Customer()
            {
                Id = 2,
                Name = "Angel Dominguez"
            };
            return new List<Customer>{usuario1,usuriario2};
           
        }
    }
}