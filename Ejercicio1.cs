using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana1
{
    internal class Ejercicio1
    {
        public void Execute()
        {
            float Altura;
            float Base;
            float Area;
            float Perimetro;

            Console.WriteLine("Dame la altura del rectangulo");

            Altura = Get();

            Console.WriteLine("Dame la base del rectangulo");

            Base = Get();

            Area = Base * Altura;

            Perimetro = (Base * 2) + (Altura * 2);

            Console.WriteLine("Su area es " + Area);


            Console.WriteLine("Su perimetro es " + Perimetro);
        }

        float Get()
        {
            float valor;
            valor = float.Parse(Console.ReadLine());

            while (valor <= 0)
            {
                Console.WriteLine("El valor debe ser mayor a 0");
                valor = float.Parse(Console.ReadLine());

            }

            return valor;
        }

    }
}
