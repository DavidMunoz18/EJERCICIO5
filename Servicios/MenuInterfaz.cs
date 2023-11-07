using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5.Servicios
{
    /// <summary>
    /// Interfaz que declara el metodo de pedir el mes y año.
    /// 071123 - dmp
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menu y recoge la selección del usuario.
        /// 071123 - dmp
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// Metodo para solicitar al usuario un mes y devolverlo como numero.
        /// 071123 - dmp
        /// </summary>
        /// <returns></returns>
        public int mes();

        /// <summary>
        /// Metodo para solicitar al usuario un año y devolverlo como numero.
        /// 071123 - dmp
        /// </summary>
        /// <returns></returns>

        public int anyo();
    }
}
