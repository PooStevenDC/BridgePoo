using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    //Aqui se crea la primera clase de implementacion y se hereda de la Interfaz Ibridge para que asi
    //se establezcan los metodos que daran un  resultado eespecifico
    class CImplementacion1:IBridge
    {
         

        void IBridge.MostrarTotales(Dictionary<string, double> pProductos)//metodo para mostrar el total de productos
        {
            double total = 0;//variabe para calcular total de productos
            int cantidad = 0;//variable para saber la cantidad de roductos que tenemos

            foreach (KeyValuePair<string, double> p in pProductos)//imprime el total de productos 
            {
                total += p.Value;
                cantidad++;
            }

            Console.WriteLine("El total de {0} productos es $ {1}", cantidad, total);
        }

        void IBridge.ListarProductos(Dictionary<string, double> pProductos)// metodo para listar productos
        {
            foreach (KeyValuePair<string, double> p in pProductos)// impreme productos
            {
                Console.WriteLine(p.Key);
            }
        }
    }
}
