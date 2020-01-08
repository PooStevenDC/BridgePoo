using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    //Supongamos que el programa quiera cambiar de mecanismo, entonses hay es donde entra esta clase que es Implementacion2
    //donde va heredar los metodos de la Interfaz Ibridge pero en esos metodos se hacen dstintos procesos, asi estariamos
    //implementandos requesitos que la primera implementacion 
    class CImplementacion2 : IBridge
    {
        public void ListarProductos(Dictionary<string, double> pProductos)
        {
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                if (p.Key[0] == 'C')
                    Console.ForegroundColor = ConsoleColor.Blue;// Si la inicial de producto es C se imprime de color azul
                if (p.Key[0] == 'M')
                    Console.ForegroundColor = ConsoleColor.Yellow;//Si la inicial es M se imprime de color amarillo
                if (p.Key[0] == 'D')
                    Console.ForegroundColor = ConsoleColor.Gray;// Si la  inicial es D se imprime de color griss

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
                if (p.Key[0] == 'C')// Se suman los totales con la inicial C
                    totalc += p.Value;
                if (p.Key[0] == 'M')// Se suman los totales con la inicial M
                    totalm += p.Value;
                if (p.Key[0] == 'D')// Se suman los productos con la inicial D
                    totald += p.Value;

                cantidad++;
            }
             
            Console.WriteLine("El total de  comida es {0} ", totalc);
            Console.WriteLine("El total de  medicamentos es {0} ", totalm);
            Console.WriteLine("El total de  deportes es {0} ", totald);


            Console.WriteLine("El total de {0} productos es $ {1}", cantidad, total);
        }
    }
}