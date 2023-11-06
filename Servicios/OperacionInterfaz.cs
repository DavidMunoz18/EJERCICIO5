using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5.Servicios
{
    internal interface OperacionInterfaz
    {
        public void dias(int anyo, int mes);
        public void noBisiesto(int mes);
        public void Bisiesto(int mes);
    }
}
