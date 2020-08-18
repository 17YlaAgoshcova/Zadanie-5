using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5_Agoshkova
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.Write("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите в: ");
            int b = Convert.ToInt32(Console.ReadLine());

            void maxim(int aa, int bb, out int cc)
            {
                if (aa > bb)
                {
                    cc = aa;
                }
                else
                {
                    cc = bb;
                }
            }

            maxim(a, b, out c);

            Console.WriteLine($"Максимальное число: {c}");
            Console.ReadKey();

        }
    }
}
