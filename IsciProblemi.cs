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
            float gun, isci, sonuc;

            Console.WriteLine("Bir işçi işi kaç günde bitirmektedir?");
            gun = int.Parse(Console.ReadLine());

            Console.WriteLine("Toplam kaç işçi çalışacak?");
            isci = int.Parse(Console.ReadLine());

            sonuc = gun / isci;

            Console.WriteLine(sonuc.ToString()+" günde bitirirler");

            Console.ReadKey();

        }
    }
}
