using System.Text;
using System.Threading.Tasks;

namespace kodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i > 0; i--)
            {
                if (i%13==0)
                {
                    Console.WriteLine(i.ToString());
                }
            }

            Console.ReadKey();

        }
    }
}
