using EJERCICIO5.Servicios;

namespace EJERCICIO5.Controladores
{
    
    class program
    {
        
        static void Main(string[] args)
        {
            // Crear una instancia de MenuInterfaz e inicializarla como una instancia de MenuImplementacion.
            MenuInterfaz mi = new MenuImplementacion();
            //Crear una instacia de OperacionInterfaz e iniciazarla como una instancia de OperacionImplementacion.
            OperacionInterfaz oi = new OperacionImplementacion();
            {
                //Variables para controlar el bucle y la opcion Introducida.
                bool cerrarMenu = false;
                int opcionIntroducida;
                while(!cerrarMenu)
                {
                    //Mostrar el menu y obtener la opcion seleccionada.
                    opcionIntroducida = mi.mostrarMenuYSeleccion();
                    switch(opcionIntroducida)
                    {
                        case 0:
                            //Si la opcion es 0 cerrar el menu.
                            cerrarMenu |= true;
                            break;
                        case 1:
                            //Si la opcion es 1 solicitar al usuario un mes y un año.
                            int mes = mi.mes();

                            int anyo = mi.anyo();

                            oi.dias(anyo,mes);
                            break;

                    }
                }
            }
        }
    }
}