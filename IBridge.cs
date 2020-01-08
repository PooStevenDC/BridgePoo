using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    //Esta es la interfaz que las implementaciones deben mostrar
    interface IBridge
    {
        //Estos metodos se crean para hacer las distintas implementaciones que se quieran establecer en nuestro programa
        void MostrarTotales(Dictionary<string, double> pProductos);// pasamos por parametro un diccionaro para asi tener
                                                                    // tener nombres de productos y su valor
        void ListarProductos(Dictionary<string, double> pProductos);
    }
}
