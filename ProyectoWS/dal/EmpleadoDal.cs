using ProyectoWS.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWS.dal
{
    public class EmpleadoDal
    {
        public static List<EMPLEADOS> Listar()
        {
            using (var model2 = new Model2())
            {
                return model2.EMPLEADOS.ToList();
            }
        }

    }
}