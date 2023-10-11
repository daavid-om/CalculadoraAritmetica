using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmética.Servicios
{
    /// <summary>
    /// clase que implementa los cálculos de la calculadora
    /// </summary>
    internal class CalculadoraImplementacion : CalculadoraInterface
    {
        public void dividir()
        {
            int num1 = PedirNumeros();
            int num2 = PedirNumeros();
            int division=num1 / num2;
            Console.WriteLine(" el resultado de la división es: "+ division);
        }

        public void multiplicar()
        {
            int num1 = PedirNumeros();
            int num2 = PedirNumeros();
            int multiplicar=num1 * num2;
            Console.WriteLine("el resultado de la multiplicación es: "+ multiplicar);
        }

        public void resta()
        {
            int num1 = PedirNumeros();
            int num2 = PedirNumeros();
            int resta = num1 - num2;
            Console.WriteLine(" el resultado de la resta es: " + resta);
        }

        public void suma()
        {
            int num1 = PedirNumeros();
            int num2 = PedirNumeros();
            int suma = num1 + num2;
            Console.WriteLine(" el resultado de la suma es: " + suma);
        }

        private int PedirNumeros() 
        {
            int numero;
            Console.WriteLine("Introduzca el numero deseado:");
            numero=Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
