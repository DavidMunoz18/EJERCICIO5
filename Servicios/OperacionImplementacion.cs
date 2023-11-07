using EJERCICIO5.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5
{
    /// <summary>
    /// Contiene la logica de las cabeceras de los metodos.
    /// 071123 - dmp
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {
        
        public void Bisiesto(int mes)
        {
            if (mes == 1 | mes == 3 | mes == 5 | mes == 7 | mes == 8 | mes == 10 | mes == 12)
            {
                //Imprime por consola cuando el mes es bisiesto y tiene 31 dias
                Console.WriteLine("El mes tiene 31 dias");
                
            }
            else if (mes == 2)
            {
                //Imprime por consola cuando febrero es bisiesto y tiene 29 dias
                Console.WriteLine("El mes tiene 29 dias");
                
            }
            else
            {
                //Imprime por consola cuando el mes es bisiesto y tiene 30 dias
                Console.WriteLine("El mes tiene 30 dias");
                    
            }
        }


       
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


        public void noBisiesto(int mes)
        {
            if (mes == 1 | mes == 3 | mes == 5 | mes == 7 | mes == 8 | mes == 10 | mes == 12)
            {
                //Imprime por consola cuando el mes no es bisiesto y tiene 31 dias
                Console.WriteLine("El mes tiene 31 dias");
                
            }
            else if (mes == 2)
            {
                //Imprime por consola cuando febrero no es bisiesto y tiene 28 dias
                Console.WriteLine("El mes tiene 28 dias");
                
            }
            else
            {
                //Imprime por consola cuando el mes no es bisiesto y tiene 30 dias
                Console.WriteLine("El mes tiene 30 dias");
            }

        }
        
        public bool continuarOperacion()
        {
            //bucle para poder cerrar el menu o continuar con el.
            bool cerrar = false;
            Console.WriteLine("Si desea continuar pulse la tecla s");
            string continua;
            continua = Console.ReadLine();
            if (continua != "s")
            {
                cerrar = true;
            }
            else
            {
                cerrar = false;
            }
            return cerrar;
        }
    }
}
