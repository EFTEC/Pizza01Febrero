using ProyectoWS.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWS.DAL
{
    public class OrdenesDal
    {
        public static List<ORDENES> ListarOrdenes()
        {
            using (var model2 = new Model2())
            {
                return model2.ORDENES.ToList();
            }
        }
        public static void InsertarOrdenes(ORDENES ordenes)
        {
            using (var model2 = new Model2())
            {
                model2.ORDENES.Add(ordenes);
                model2.SaveChanges();
            }
        }
    }
}