using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana1
{
    internal class MenuPrincipal
    {
        public void Seleccionar()
        {
            Console.WriteLine("1 - Descubrir el area y perimetro de un rectangulo.");
            Console.WriteLine("2 - Descubrir el area y periemtro de un triangulo");
            Console.WriteLine("3 - Descubre que año fue bisiesto");
            Console.WriteLine("4 - Calculadora simple");
            Console.Write("\nIngrese un numero del 1 al 4: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    
                    Ejercicio1 ejercicio1 = new Ejercicio1();
                    ejercicio1.Execute();
                    break;
                case 2:
                    
                    TrianguloArea trianguloArea = new TrianguloArea();  
                    trianguloArea.Calcular();
                    break;
                case 3:
                    
                    Bisiesto bisiesto = new Bisiesto();
                    bisiesto.Execute();
                    break;
                case 4:
                    
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
