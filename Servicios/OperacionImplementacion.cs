using EJERCICIO5.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5
{
    //Clase interna que implementa la interfaz OperacionInterfaz.
    internal class OperacionImplementacion : OperacionInterfaz
    {
        // Método para determinar los días en un mes en un año bisiesto.
        public void Bisiesto(int mes)
        {
            if (mes == 1 | mes == 3 | mes == 5 | mes == 7 | mes == 8 | mes == 10 | mes == 12)
            {
                Console.WriteLine("El mes tiene 31 dias");
            }
            else if (mes == 2)
            {
                Console.WriteLine("El mes tiene 29 dias");
            }
            else
            {
                Console.WriteLine("El mes tiene 30 dias");
            }
        }


        // Método para determinar los días en un mes teniendo en cuenta si el año es bisiesto.
        public void dias(int anyo, int mes)
        {
            if (anyo % 4 == 0)
            {
                if (anyo % 100 != 0)
                {
                    Console.WriteLine("Año bisiesto");
                    Bisiesto(mes);
                }
                else if (anyo % 100 == 0 && anyo % 400 == 0)
                {
                    Console.WriteLine("Año bisiesto");
                    Bisiesto(mes);
                }
                else
                {
                    Console.WriteLine("Año no bisiesto");
                    noBisiesto(mes);
                }
            }
            else
            {
                Console.WriteLine("Año no bisiesto");
                noBisiesto(mes);
            }
        }


        // Método para determinar los días en un mes en un año no bisiesto.
        public void noBisiesto(int mes)
        {
            if (mes == 1 | mes == 3 | mes == 5 | mes == 7 | mes == 8 | mes == 10 | mes == 12)
            {
                Console.WriteLine("El mes tiene 31 dias");
            }
            else if (mes == 2)
            {
                Console.WriteLine("El mes tiene 28 dias");
            }
            else
            {
                Console.WriteLine("El mes tiene 30 dias");
            }
        }
    }
}
