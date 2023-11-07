using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5.Servicios
{
    /// <summary>
    /// Contiene las cabeceras de los metodos.
    /// 071123 - dmp
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Método para determinar si es un año bisiesto o no.
        /// 071123 - dmp
        /// </summary>
        /// <param name="anyo"></param>
        /// <param name="mes"></param>
        public void dias(int anyo, int mes);

        /// <summary>
        /// Método para determinar los días en un mes en un año no bisiesto.
        /// 071123 - dmp
        /// </summary>
        /// <param name="mes"></param>
        public void noBisiesto(int mes);

        /// <summary>
        /// Método para determinar los días en un mes en un año bisiesto.
        /// 071123 - dmp
        /// </summary>
        /// <param name="mes"></param>
        public void Bisiesto(int mes);

        /// <summary>
        /// Metodo para continuar la aplicacion pulsando la tecla s.
        /// 071123 - dmp
        /// </summary>
        /// <returns></returns>
        public bool continuarOperacion();

    }
}
