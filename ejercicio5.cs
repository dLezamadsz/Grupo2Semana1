using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cih
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string continuar = "s";

                while (continuar == "s")
                {
                    Console.WriteLine("Ingrese un número entero positivo:");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese otro número entero positivo:");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("¿Qué operación quieres realizar? (+, -, *, /, %)");
                    string operacion = Console.ReadLine();

                    int resultado = 0;

                    switch (operacion)
                    {
                        case "+":
                            resultado = num1 + num2;
                            break;

                        case "-":
                            resultado = num1 - num2;
                            break;

                        case "*":
                            resultado = num1 * num2;
                            break;

                        case "/":
                            resultado = num1 / num2;
                            break;

                        case "%":
                            resultado = num1 % num2;
                            break;

                        default:
                            Console.WriteLine("Operación no válida.");
                            break;
                    }

                    Console.WriteLine("El resultado de la operación es: " + resultado);

                    Console.WriteLine("¿Desea realizar otra operación? (s/n)");
                    continuar = Console.ReadLine().ToLower();
                }

                Console.WriteLine("Calculadora finalizada.");
            }
        }
    }
}
