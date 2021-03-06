﻿
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
                if (leer!=null && leer.CLAVE==emp.CLAVE)
                {
                    Session["usuario"]=emp;
                    Response.Redirect("/Empleado/PantallaInicial/");
                } else
                {
                    ViewBag.mensaje="Usuario incorrecto";
                    // quizas podemos mostrar un mesaje
                }
            }
            return View(emp);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            Session["usuario"]=null; // otra alternativa
            Response.Redirect("Empleado/Login");
            return View();
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