using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmética.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos con la calculadora
    /// 101023 - dom
    /// </summary>
    internal interface CalculadoraInterface
    {
        /// <summary>
        /// Metodo para sumar
        /// 101023 - dom
        /// </summary>
        public void suma();
        /// <summary>
        /// Metodo para restar
        /// 101023 - dom
        /// </summary>
        public void resta();
        /// <summary>
        /// Metodo para multiplicar
        /// 101023 - dom
        /// </summary>
        public void multiplicar();
        /// <summary>
        /// Metodo para dividir
        /// 101023 - dom
        /// </summary>
        public void dividir();
    }
}
