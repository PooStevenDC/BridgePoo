using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //intsnciamos diccionario para agregar el producto y su valos
            Dictionary<string, double> productos = new Dictionary<string, double>();
            productos.Add("M101", 56.3);
            productos.Add("M234", 23.8);
            productos.Add("C654", 974.5);
            productos.Add("M230", 43.2);
            productos.Add("C486", 785.1);
            productos.Add("D645", 432.5);
            productos.Add("M789", 874.5);
            productos.Add("D947", 23.1);
            productos.Add("C235", 43.1);
            productos.Add("M589", 21.4);
             
        // Se instancia la clase abstracta para asi establecer los metodos a ejecutar
          CAbstraccion bridge= new CAbstraccion(new CImplementacion3(),productos);
            // Como podemos ver los metodos no van a cambiar
            // si se implementan distintos procesos con estos metodos nosotros podemos ejecutar las 
            //tres implementaciones que son
            //CImplementacion1()
            //CImplementacion2()
            //CImplementacion3()
            //Cada una dara un proceso distinto
            bridge.MostrarTotales();
            bridge.Listar();
        }
    }
    
}
