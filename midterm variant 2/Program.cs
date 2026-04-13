using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_variant_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = 1;
            int c = 0;
            bool hasilvar= false;

            for (int i = 0; i < 10; i++) {
                int a;
                a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                {
                    c = c + a;
                }
                else {
                    h = h * a;
                    hasilvar = true;
                }
            }
            if (!hasilvar) h = 0;
            Console.WriteLine($"Teklerin hasili {h}, Cutlerin cemi {c}");

        }
    }
}
