using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR100823
{
    /// <summary>
    /// Clase que contiene métodos para realizar validaciones de entrada de usuario
    /// </summary>
    /// <remarks>
    /// <autor>Ronald Mejia</autor>
    /// MR100823
    /// </remarks>
    internal class Validaciones
    {
        /// <summary>
        /// Método que solicita al usuario que ingrese un número y lo valida hasta que se ingrese un valor numérico válido
        /// </summary>
        /// <returns>El número ingresado por el usuario</returns>
        public static double GetNumero()
        {
            Console.Write("Ingrese un número: ");
            string input = Console.ReadLine();

            double numero;
            while (!double.TryParse(input, out numero))
            {
                Console.Write("Error: solo se permiten números. \nIntente nuevamente: ");
                input = Console.ReadLine();
            }

            return numero;
        }

        /// <summary>
        /// Metodo que solicita al usuario ingresar un numero y valida que se ingrese un valor entero valido
        /// </summary>
        /// <returns>Numero ingresado por el usuario</returns>
        public static int GetNumeroEntero()
        {
            Console.Write("Ingrese un número: ");
            string input = Console.ReadLine();

            int numero;
            while (!int.TryParse(input, out numero))
            {
                Console.Write("Error: solo se permiten números. \nIntente nuevamente: ");
                input = Console.ReadLine();
            }

            return numero;
        }
    }
}