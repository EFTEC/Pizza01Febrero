using ProyectoWeb.ClientesWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarClientes()
        {
            using(var clientesws=new ClientesWS.ClientesWSSoapClient())
            {
                ViewBag.listaclientes=clientesws.Listar();
            }
            return View();
        }

        [HttpGet]
        public ActionResult IngresarCliente()
        {
            CLIENTES cli=new CLIENTES();
            return View(cli);
        }
        [HttpPost]
        public ActionResult IngresarCliente(CLIENTES cli)
        {
            using(var clientesws=new ClientesWS.ClientesWSSoapClient())
            {
                clientesws.Insertar(cli);
            }
            Response.Redirect("/Cliente/ListarClientes");
            return View(cli);
        }
    }
}