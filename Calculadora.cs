using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR100823
{
    /// <summary>
    /// Clase encargada de manejar la logica necesaria para realizar operaciones basicas de una calculadora 
    /// </summary>
    /// <remarks>
    /// <autor>Ronald Mejia</autor>
    /// MR100823
    /// </remarks>
    internal class Calculadora
    {
        /// <summary>
        /// Atributos de clases calculadora
        /// </summary>
        private double numero1;
        private double numero2;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Calculadora()
        {
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        public Calculadora(double numero1, double numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        /// <summary>
        /// Metodo que se encarga de sumar dos numeros 
        /// Metodo de tipo instancia
        /// </summary>
        /// <returns>Resultado de la suma</returns>
        public double Sumar() => numero1 + numero2;

        /// <summary>
        /// Metodo que se encarga de resta dos numeros 
        /// Metodo de tipo instancia
        /// </summary>
        /// <returns>Resultado de la resta</returns>
        public double Restar() => numero1 - numero2;

        /// <summary>
        /// Metodo que se encarga de multiplicacion dos numeros 
        /// Metodo de tipo instancia
        /// </summary>
        /// <returns>Resultado de la multiplicacion</returns>
        public double Multiplicar() => numero1 * numero2;

        /// <summary>
        /// Metodo que se encarga de dividir dos numeros
        /// Metodo de tipo instancia
        /// </summary>
        /// <returns>Resultado de la division</returns>
        /// <exception cref="DivideByZeroException">Si tratas de dividir entre cero</exception>
        public double Dividir() => numero2 == 0 ? throw new DivideByZeroException("No puedes dividir entre cero") : numero1 / numero2;


        /// <summary>
        /// Metodo que se encarga de sumar dos numeros 
        /// Metodo de tipo clase
        /// </summary>
        /// <param name="pNum1">num1 de tipo double</param>
        /// <param name="pNum2">num2 de tipo double</param>
        /// <returns>Resultado de la suma</returns>
        public static double Sumar(string pNum1, string pNum2)
        {
            double num1 = Convert.ToDouble(pNum1);
            double num2 = Convert.ToDouble(pNum2);
            return num1 + num2;
        }

        /// <summary>
        /// Metodo que se encarga de restar dos numeros 
        /// Metodo de tipo clase
        /// </summary>
        /// <param name="pNum1">num1 de tipo double</param>
        /// <param name="pNum2">num2 de tipo double</param>
        /// <returns>Resultado de la resta</returns>
        public static double Restar(string pNum1, string pNum2)
        {
            double num1 = Convert.ToDouble(pNum1);
            double num2 = Convert.ToDouble(pNum2);
            return num1 - num2;
        }

        /// <summary>
        /// Metodo que se encarga de multiplicar dos numeros 
        /// Metodo de tipo clase
        /// </summary>
        /// <param name="pNum1">num1 de tipo double</param>
        /// <param name="pNum2">num2 de tipo double</param>
        /// <returns>Resultado de la multiplicacion</returns>
        public static double Multiplicacion(string pNum1, string pNum2)
        {
            double num1 = Convert.ToDouble(pNum1);
            double num2 = Convert.ToDouble(pNum2);
            return num1 * num2;

        }
        /// <summary>
        /// Metodo que se encarga de dividir dos numeros
        /// Metodo de tipo clase
        /// </summary>
        /// <param name="pNum1"></param>
        /// <param name="pNum2"></param>
        /// <returns>resultado de la division</returns>
        /// <exception cref="DivideByZeroException">En caso de que intentes dividir entre cero</exception>
        public static double Dividir(string pNum1, string pNum2) {
            double num1 = Convert.ToDouble(pNum1);
            double num2 = Convert.ToDouble(pNum2);

            if(num2 == 0) {
                throw new DivideByZeroException("No podemos dividir entre cero");
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}

