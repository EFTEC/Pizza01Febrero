using ProyectoWS.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWS.DAL
{
    public class PizzasDal
    {
        public static List<PIZZAS> ListarPizzas()
        {
            using (var model2 = new Model2())
            {
                return model2.PIZZAS.ToList();
            }
        }
    }
}