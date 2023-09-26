using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBienvenida.Servicios
{  
    /// <summary>
    /// Interfaz que corresponde a la funcionalidad de menú
    /// Interfaz que contiene todas las acciones 
    /// </summary>
    internal interface MenuInterfaz
    {  
        /// <summary>
        /// Método que mostrara el mensaje de bienvenida al cajero.
        /// </summary>
        public void mensajeBienvenida();
        /// <summary>
        /// Método que muestra el menú que recoge la seleccion del usuario 
        /// </summary>
        /// <returns>un entero con la opcion seleccionada</returns>
        public int mostrarMenuYSeleccion();
    }

}
