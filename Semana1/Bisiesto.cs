using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana1
{
    internal class Bisiesto
    {
        public void Execute()
        {
            Console.WriteLine("Ingrese año a verificar;");
            int y = int.Parse(Console.ReadLine());
            Verify(y);
        }

        private void Verify(int y)
        {
            if (y % 400 == 0)
            {
                Console.WriteLine(y+" es un año bisiesto.");
            }
            else if(y%4==0 && y % 100 != 0)
            {
                Console.WriteLine(y + " es un año bisiesto.");
            }
            else
            {
                Console.WriteLine(y + " no es un año bisiesto.");
            }
        }
    }
}
