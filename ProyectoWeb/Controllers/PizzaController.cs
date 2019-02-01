using ProyectoWeb.OrdenesWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult IngresarOrden()
        {
            ORDENES ordenes=new ORDENES();
            // necesito un listado de pizza
            using(var pissaWS=new PizzaWS.PizzasWSSoapClient())
            {
                ViewBag.listapizza=pissaWS.Listar();
                //PIZZAS pizza=new PIZZAS();
            }
            // necesito un lsitado de clientes
            using(var clientesWS=new ClientesWS.ClientesWSSoapClient())
            {
                ViewBag.listacliente=clientesWS.Listar();
            }
            return View();
        }
        [HttpPost]
        public ActionResult IngresarOrden(ORDENES ordenes)
        {
            // necesito un listado de pizza
            using(var pissaWS=new PizzaWS.PizzasWSSoapClient())
            {
                ViewBag.listapizza=pissaWS.Listar();
            }
            // necesito un lsitado de clientes
            using(var clientesWS=new ClientesWS.ClientesWSSoapClient())
            {
                ViewBag.listacliente=clientesWS.Listar();
            }
            using(var ordenesWS=new OrdenesWS.OrdenesWSSoapClient())
            {
                ordenesWS.Insertar(ordenes);
            }
            return View();
        }
    }
}