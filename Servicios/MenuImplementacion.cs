using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmética.Servicios
{
    /// <summary>
    /// clase que implementa a la interfaz del menú
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opcionIntroducida;
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            opcionIntroducida = Console.ReadKey(true).KeyChar-('0');

            return opcionIntroducida;
        }
           
    }
}
