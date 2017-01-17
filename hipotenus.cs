using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            double dik1, dik2, hipotenus;

            Console.WriteLine("1. dik kenar ");
            dik1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. dik kenar ");
            dik2 = int.Parse(Console.ReadLine());

            hipotenus = Math.Sqrt(dik1 * dik1 + dik2 * dik2);

            Console.WriteLine("Hipotenüs uzunluğu: "+hipotenus.ToString());

            Console.ReadKey();

        }
    }
}
