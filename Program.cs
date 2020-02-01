using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3_EjerciciosConsola.Capitulo10
{
    class Ejercicio1
    {
        public Ejercicio1()
        {
            nombreProducto = "";
            marcaProducto = "";
            precio = 0;
            existencia = 0;
        }
        public void Accion()
        {
            Console.WriteLine("Ingrese nombre");
            nombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese marca producto");
            marcaProducto = Console.ReadLine();

            Console.WriteLine("Ingrese precio");
            precio = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese existencia");
            precio = Convert.ToInt32(Console.ReadLine());
        }


        private string nombreProducto;
        private string marcaProducto;
        private decimal precio;
        private int existencia;
    }
  
}



