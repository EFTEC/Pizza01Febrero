using ProyectoWS.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWS.DAL
{
    public class EmpleadosDal
    {
        public static EMPLEADOS LeerEmpleado(string usuario)
        {
            var emp = new EMPLEADOS();
            using (var grupo = new Model2())
            {
                emp = grupo.EMPLEADOS
                    .Where(e => e.USUARIO == usuario).FirstOrDefault(); // devuelve el primero, sino se cae.
                return emp;
            }
        }
        public static List<EMPLEADOS> ListarEmpleado()
        {
            using (var model2 = new Model2())
            {
                return model2.EMPLEADOS.ToList();
            }
        }
    }
}