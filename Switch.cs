using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana1
{
    internal class Switch
    {
        public void Seleccionar()
        {
            Console.WriteLine("Ingrese un número del 1 al 5:");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("1 - Descubrir el area y perimetro de un rectangulo.");
                    Ejercicio1 ejercicio1 = new Ejercicio1();
                    ejercicio1.Execute();
                    break;
                case 2:
                    Console.WriteLine("2 - Descubrir el area y periemtro de un triangulo");
                    TrianguloArea trianguloArea = new TrianguloArea();  
                    trianguloArea.Calcular();
                    break;
                case 3:
                    Console.WriteLine("3 - Descubre que año fue bisiesto");
                    Bisiesto bisiesto = new Bisiesto();
                    bisiesto.Execute();
                    break;
                case 4:
                    Console.WriteLine("4 - Calculadora simple");
                    Ejercicio4 ejercicio4 = new Ejercicio4();
                    ejercicio4.Execute();
                    break;
                default:
                    Console.WriteLine("Número fuera de rango.");
                    break;
            }
        }
    }
}
