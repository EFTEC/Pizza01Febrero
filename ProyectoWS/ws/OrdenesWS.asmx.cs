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
    /// Summary description for OrdenesWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrdenesWS : System.Web.Services.WebService
    {

        [WebMethod]
        public List<ORDENES> Listar()
        {
            return OrdenesDal.ListarOrdenes();
        }
        [WebMethod]
        public void Insertar(ORDENES ordenes)
        {
            OrdenesDal.InsertarOrdenes(ordenes);
        }
    }
}
