using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    //Esta clase conecta al cliente con la abstraccion a utilizar
    
    class CAbstraccion
    {
        IBridge implementacion;//variable de referencia que conecta con las instancias de las n implementaciones 
        Dictionary<string, double> productos;// diccionario que guarda a los productos



        // En este constructor recibimos la implementacion que se realice
        public CAbstraccion(IBridge pImple, Dictionary<string, double> pProd )
        {
            implementacion = pImple;
            productos = pProd;
        }

         

        //Estos metodos representan la interfaz que conoce el cliente
        // Es decir con esto llamamos en el program

        public void MostrarTotales ()
        {
            implementacion.MostrarTotales(productos);//Este proceso muestra los totales de productos 
                                                     //dependiendo de que implementacion estemos usando
        }
        public void Listar()
        {
            implementacion.ListarProductos(productos);// Aqui imprime el listado dependiendo  que implementacion
                                                      //se utilice
        }
    }
}
