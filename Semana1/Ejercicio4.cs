using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana1
{
    internal class Ejercicio4
    {
        public void Execute()
        {

            Console.WriteLine("Ingrese un número entero positivo:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número entero positivo:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Que operacion quieres realizar? (+, -, *, /)");
            string operacion = Console.ReadLine();

            int resultado = 0;

            if (operacion == "+")
            {
                resultado = num1 + num2;
            }
            else if (operacion == "-")
            {
                resultado = num1 - num2;
            }
            else if (operacion == "*")
            {
                resultado = num1 * num2;
            }
            else if (operacion == "/")
            {
                resultado = num1 / num2;
            }
            Console.WriteLine("El resultado de la operación es: " + resultado);

        }
    }
}
