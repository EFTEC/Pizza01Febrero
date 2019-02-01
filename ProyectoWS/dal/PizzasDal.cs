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
                model2.Configuration.ProxyCreationEnabled=false;
                List<PIZZAS> lista=model2.PIZZAS.ToList();
                return lista;
            }
        }

         public static void ModificarPizza(PIZZAS pizza)
        {
            using (var model2 = new Model2())
            {
                // modificacion
                PIZZAS pizzaAntigua=model2.PIZZAS
                    .Where(p=>p.IDPIZZA==pizza.IDPIZZA).FirstOrDefault();
                pizzaAntigua.PRECIO=pizza.PRECIO;
                pizzaAntigua.IMAGEN=pizza.IMAGEN;
                pizzaAntigua.TITULO=pizza.TITULO;
                model2.SaveChanges();
            }
        }
    }
}