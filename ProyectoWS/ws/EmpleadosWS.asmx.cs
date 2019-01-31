using ProyectoWS.DAL;
using ProyectoWS.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProyectoWS.ws
{
    /// <summary>
    /// Summary description for EmpleadosWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EmpleadosWS : System.Web.Services.WebService
    {

        [WebMethod]
        public EMPLEADOS Leer(string usuario)
        {
            return EmpleadosDal.LeerEmpleado(usuario);
        }

        [WebMethod]
        public List<EMPLEADOS> Listar()
        {
            return EmpleadosDal.ListarEmpleado();
        }

    }
}
