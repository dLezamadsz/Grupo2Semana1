using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana1
{
    class TrianguloArea
    {
        public void Calcular()
        {
            //Leer la base y altura de un triangulo y mostrar su área
            float baseT;
            float altura;
            float area;

            Console.WriteLine("Ingresar la base del triangulo:");
            baseT = Verificar();

            Console.WriteLine("Ingresar la altura del triangulo:");
            altura = Verificar();

            area = (baseT * altura) / 2;
            Console.WriteLine($"El área del triángulo es: {area}");
        }

        float Verificar()
        {
            float num;
            while (!float.TryParse(Console.ReadLine(), out num) || num <= 0)
                {
                    Console.WriteLine("Ingrese un número válido");
                }
            return num;
        }
    }
}