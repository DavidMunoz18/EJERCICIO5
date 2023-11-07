using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5.Servicios
{
    /// <summary>
    /// Contiene la logica de las cabeceras de los metodos.
    /// 071123 - dmp
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
       
        public int mostrarMenuYSeleccion()
        {
            //Se imprime por pantalla un menu con distintas opciones.
            int numeroIntroducido;
            Console.WriteLine("#######################################");
            Console.WriteLine("0. cerrar menu");
            Console.WriteLine("1. Se ejecuta caso 1");
            Console.WriteLine("#######################################");
            //Permite al usuario introducir un numero entero para seleccionar una opcion del menu.
            numeroIntroducido = Console.ReadKey(true).KeyChar - '0';
            return numeroIntroducido;
       
        }
        public int mes()
        {
            //Permite al usuario introducir un mes en formato de numero entero.
            int n1;
            Console.WriteLine("Introduce un mes");
            n1 = Convert.ToInt32(Console.ReadLine());

            return n1;
        
        }
        
        public int anyo()
        {
            //Permite al usuario introducir un año en formato de numero entero.
            int n2;
            Console.WriteLine("Introduce un año");
            n2 = Convert.ToInt32(Console.ReadLine());

            return n2;
        }
    }
}
