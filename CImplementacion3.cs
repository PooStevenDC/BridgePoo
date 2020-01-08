using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    // Esta es clase hace otro tipo de implementacion es muy similar a la segunda implementacion pero el proceso cambia
    //dando como resultado otro proceso que hace que se cambie el proceso del programa esta seria la implementacion 3
    class CImplementacion3 : IBridge
    {
        public void ListarProductos(Dictionary<string, double> pProductos)
        {
            foreach (KeyValuePair<string, double> p in pProductos)// Si la inicial de producto es C se imprime de color azul
            {                                                     // Ademas se imprimen primero los de esta categoria que es 
                Console.ForegroundColor = ConsoleColor.Blue;      //Color azul
                if (p.Key[0] == 'C')
                Console.WriteLine(" {0} - {1}", p.Key, p.Value);

            }
            foreach (KeyValuePair<string, double> p in pProductos)//Si la inicial es M se imprime de color amarillo
            {                                                     // La s de color amarillo se imprimen de segunda
                Console.ForegroundColor = ConsoleColor.Yellow;     
                if (p.Key[0] == 'M')
                    Console.WriteLine(" {0} - {1}", p.Key, p.Value);

            }
            foreach (KeyValuePair<string, double> p in pProductos)// Las de rojo se imprimen de tercera
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (p.Key[0] == 'D')
                    Console.WriteLine(" {0} - {1}", p.Key, p.Value);

            }
        }

        public void MostrarTotales(Dictionary<string, double> pProductos)
        {
            double total = 0;
            double totalm = 0;
            double totalc = 0;
            double totald = 0;
            int cantidad = 0;
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                total += p.Value;
                if (p.Key[0] == 'C')
                    totalc += p.Value;
                if (p.Key[0] == 'M')
                    totalm += p.Value;
                if (p.Key[0] == 'D')
                    totald += p.Value;

                cantidad++;
            }
            // Se imprime los totales de cada letra y ademas se le asigna el porcentaje 
            Console.WriteLine("El total de  comida es {0}, {1} % del total ", totalc, totalc/total*100);
            Console.WriteLine("El total de  medicamento es {0}, {1} % del total", totalm, totalm/total*100);
            Console.WriteLine("El total de  deporte es {0}, {1} % del total", totald, totald/total*100);


            Console.WriteLine("El total de {0} productos es $ {1}", cantidad, total);

        }
    }
}