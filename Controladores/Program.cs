using EJERCICIO5.Servicios;

namespace EJERCICIO5.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación.
    /// 071123 - dmp
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo de entrada de la aplicación.
        /// 071123 - dmp
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Crear una instancia de MenuInterfaz e inicializarla como una instancia de MenuImplementacion.
            MenuInterfaz mi = new MenuImplementacion();
            //Crear una instacia de OperacionInterfaz e iniciazarla como una instancia de OperacionImplementacion.
            OperacionInterfaz oi = new OperacionImplementacion();
            {
                //Variables para controlar el bucle y la opcion Introducida.
                bool cerrarMenu = false;
                //Contener la opción del usuario.
                int opcionIntroducida;
                //desde la primera iteración debe cumplirse la condición.
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
                            bool cerrar = false;
                            while(!cerrar)
                            {
                                //Llamar al metodo mes.
                                int mes = mi.mes();
                                //Llamar al metodo año.
                                int anyo = mi.anyo();

                                //Llama al metodo dias a traves de operacionInterfaz.
                                oi.dias(anyo,mes);
                                cerrar = oi.continuarOperacion();
                             
                            }
                                break;

                         
                            

                    }
                }
            }
        }
    }
}