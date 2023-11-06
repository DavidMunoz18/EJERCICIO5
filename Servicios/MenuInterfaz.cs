using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5.Servicios
{
    /// <summary>
    /// Interfaz que declara el metodo de pedir el mes y año
    /// </summary>
    internal interface MenuInterfaz
    {
        public int mostrarMenuYSeleccion();
        public int mes();

        public int anyo();
    }
}
