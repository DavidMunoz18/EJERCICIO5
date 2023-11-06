using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        //Metodo para mostrar el menu y obtener la opcion del usuario.
        public int mostrarMenuYSeleccion()
        {
            //Se imprime por pantalla un menu con distintas opciones.
            int numeroIntroducido;
            Console.WriteLine("#######################################");
            Console.WriteLine("0. cerrar menu");
            Console.WriteLine("1. Se ejecuta caso 1");
            Console.WriteLine("#######################################");
            numeroIntroducido = Console.ReadKey(true).KeyChar - '0';
            return numeroIntroducido;
       
        }
        //Metodo para solicitar al usuario un mes y devolverlo como numero.
        public int mes()
        {
            int n1;
            Console.WriteLine("Introduce un mes");
            n1 = Convert.ToInt32(Console.ReadLine());

            return n1;
        
        }
        //Metodo para solicitar al usuario un año y devolverlo como numero.
        public int anyo()
        {
            int n2;
            Console.WriteLine("Introduce un año");
            n2 = Convert.ToInt32(Console.ReadLine());

            return n2;
        }
    }
}
