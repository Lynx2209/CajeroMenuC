using ClaseBienvenida.Servicios;

namespace ClaseBienvenida{
    /// <summary>
    /// Clase principal de la aplicación 
    /// </summary>
}
    
   
    class Programm
    {
    private const int V = 0;

    /// <summary>
    /// Método de entrada a la aplicación
    /// contiene el proccedimiento o flujo de nuestra aplicación
    /// 200923 - JL
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
        {
            MenuInterfaz menuInterfaz = new MenuImplementacion();
        
            menuInterfaz.mensajeBienvenida();

            /// Variable que controla la entrada y alida del bucle while
            bool cerrarMenu = false;
            //contener la opcion del usuario
            int opcionSeleccionada;

            // desde la primera interación debe cumplirse la condición 
           while (!cerrarMenu)
           {
            opcionSeleccionada = menuInterfaz.mostrarMenuYSeleccion();
            switch (opcionSeleccionada)
            {
              case 0:
                 Console.WriteLine("[INFO] - Se ejecuta la opcion 0 .");
                    cerrarMenu = true;  
                break;
                   
              case 1: 
                Console.WriteLine("[INFO] - Se ejecuta la opcion 1.");
                break;
            
              case 2: 
                Console.WriteLine("[INFO] - Se ejecuta la opcion 2.");
                 break;
            
                case 3: 
                Console.WriteLine("[INFO] - Se ejecuta la opcion 3.");
                break;
            
                case 4: 
                Console.WriteLine("[INFO] - Se ejecuta la opcion 4.");
                break;
            
                case 5: 
                Console.WriteLine("[INFO] - Se ejecuta la opcion 5.");
                break;
            
                default:
                    Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                    break;

            }       
        
        
           }
        }

    }

