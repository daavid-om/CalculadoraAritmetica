using CalculadoraAritmética;
using CalculadoraAritmética.Servicios;
using System.Diagnostics.CodeAnalysis;

namespace CalculadoraAritmética
{
    /// <summary>
    /// clase principal
    /// 091023-dom
    /// </summary>
    class program
    {
        /// <summary>
        /// Método entrada a la calculadora
        /// 091023-dom
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            //Creamos los objetos
            MenuInterfaz mi = new MenuImplementacion();
            CalculadoraInterface ci = new CalculadoraImplementacion();
            //variable que controla la entrada y salida del bool
            bool cerrarMenu = false;
            //contener la opción del usuario
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenu();
                switch(opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cierra la aplicacion");
                        cerrarMenu = true;
                        break;

                    case 1: 
                        Console.WriteLine("[INFO] Ha seleccionado la opción sumar");
                        ci.suma();
                        break;

                    case 2: 
                        Console.WriteLine("[INFO] Ha seleccionado la opción restar");
                        ci.resta();
                        break;

                    case 3: 
                        Console.WriteLine("[INFO] Ha seleccionado la opción multiplicar");
                        ci.multiplicar();
                        break;

                     case 4: 
                        Console.WriteLine("[INFO] Ha seleccionado la opción dividir");
                        ci.dividir();
                        break;

                    default:
                        Console.WriteLine("[INFO] - La opción seleccionada no existe");
                        break;
                }
            }
        }
    }
}