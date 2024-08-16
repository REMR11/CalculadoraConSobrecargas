using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR100823
{
    /// <summary>
    /// Clase principal del programa que contiene el método Main
    /// </summary>
    /// <remarks>
    /// <autor>Ronald Mejia</autor>
    /// MR100823
    /// </remarks>
    internal class Program
    {
        /// <summary>
        /// Punto de entrada del programa
        /// </summary>
        static void Main(string[] args)
        {
            // Crear un objeto HistorialOperaciones para registrar las operaciones
            HistorialOperaciones operaciones = new HistorialOperaciones();

            // Crear un objeto Calculadora para realizar operaciones matemáticas
            Calculadora calculadora = new Calculadora();
            double num1 = 0, num2 = 0;
            string numero1 = "", numero2 = "";
            double result=0;
            // Bucle infinito para mostrar el menú y procesar las opciones del usuario
            while (true)
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("---------");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Mostrar historial");
                Console.WriteLine("6. Salir");

                Console.Write("Seleccione una opción: ");
                int opcion = Validaciones.GetNumeroEntero();

                switch (opcion)
                {
                    case 1:
                        // Sumar dos números
                        num1 = Validaciones.GetNumero();
                        num2 = Validaciones.GetNumero();
                        calculadora = new Calculadora(num1, num2);
                        double resultado = calculadora.Sumar();

                        operaciones.RegistrarOperacion(num1 + " + " + num2 + " = " + resultado);

                        Console.WriteLine($"El resultado de la suma es: {resultado}");
                        break;
                    case 2:
                        // Restar dos números
                        Console.Write("Ingrese el primer número: ");
                        numero1 = Console.ReadLine();
                        Console.Write("Ingrese el segundo número: ");
                        numero2 = Console.ReadLine();
                        result = Calculadora.Restar(numero1, numero2);

                        operaciones.RegistrarOperacion(num1 + " - " + num2 + " = " + result);

                        Console.WriteLine($"El resultado de la resta es: {result}");
                        break;
                    case 3:
                        // Multiplicar dos números
                        Console.Write("Ingrese el primer número: ");
                        numero1 = Console.ReadLine();
                        Console.Write("Ingrese el segundo número: ");
                        numero2 = Console.ReadLine();
                        result = Calculadora.Multiplicacion(numero1, numero2);
                        
                        operaciones.RegistrarOperacion(num1 + " * " + num2 + " = " + result);

                        Console.WriteLine($"El resultado de la multiplicación es: {result}");
                        break;
                    case 4:
                        // Dividir dos números
                        num1 = Validaciones.GetNumero();
                        num2 = Validaciones.GetNumero();
                        calculadora = new Calculadora(num1, num2);
                        try
                        {
                            resultado = calculadora.Dividir();
                            operaciones.RegistrarOperacion(num1 + " + " + num2 + " = " + resultado);
                            Console.WriteLine($"El resultado de la división es: {resultado}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            operaciones.RegistrarOperacion("SINTAX ERROR");
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;
                    case 5:
                        // Mostrar historial de operaciones
                        List<string> historial = operaciones.GetOperaciones();
                        Console.WriteLine("Historial de operaciones:");
                        
                        historial.ForEach(h => Console.WriteLine($"Operacion: {h}"));
                        
                        break;
                    case 6:
                        // Salir del programa
                        Console.WriteLine("Adiós!");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}