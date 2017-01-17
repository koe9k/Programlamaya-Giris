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
            int sayi1, sayi2, payda=1, pay=1, sonuc;

            Console.Write("Eleman sayısı: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Seçileceklerin sayısı: ");
            sayi2 = int.Parse(Console.ReadLine());

            for (int i = sayi1; i > 1; i--)
            {
                pay = pay * i;
            }

            for (int x = sayi2; x > 1; x--)
            {
                payda = payda * x;
            }

            for (int y = sayi1-sayi2; y > 1; y--)
            {
                payda = payda * y;
            }

            sonuc = pay / payda;
            
            Console.WriteLine(sonuc.ToString());
            Console.ReadKey();

        }
    }
}
