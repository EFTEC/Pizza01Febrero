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
    /// Summary description for ClientesWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ClientesWS : System.Web.Services.WebService
    {

        [WebMethod]
        public List<CLIENTES> Listar()
        {
            return ClientesDal.ListarClientes();
        }
        [WebMethod]
        public void Insertar(CLIENTES cliente)
        {
            ClientesDal.InsertarClientes(cliente);
        }
    }
}
