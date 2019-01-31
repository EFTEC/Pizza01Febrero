using ProyectoWeb.EmpleadosServiceReference;
using ProyectoWeb.EmpleadosWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            EMPLEADOS emp = new EMPLEADOS();



            return View(emp);
        }
        [HttpPost]
        public ActionResult Login(EMPLEADOS emp)
        {
            using(var clientews=new EmpleadosWS.EmpleadosWSSoapClient()) {
                EMPLEADOS leer=clientews.Leer(emp.USUARIO);
                if (leer.CLAVE==emp.CLAVE)
                {
                    // redirecciona
                } else
                {
                    // quizas podemos mostrar un mesaje
                }
            }

            return View(emp);
        }
        public ActionResult PantallaInicial()
        {
            return View();
        }

        public ActionResult ListarEmpleados()
        {
            return View();
        }
    }
}