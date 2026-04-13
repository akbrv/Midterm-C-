using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_variant_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            do {
                Console.WriteLine("Nece eded isteyirsiniz(1-10 arasi): ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n<1 || n > 10);

            int[] ededler = new int[n];
            for (int i = 0; i < n; i++) {
                int.TryParse(Console.ReadLine(), out ededler[i]);
            }

            int m = ededler[0];
            int f = ededler[0];
            double s = 0;

            foreach (int e in ededler) {
                if (e > m) m = e;
                if (e < f) f = e;
                s += e;

            }

            Console.WriteLine($"En boyuk eded {m}");
            Console.WriteLine($"En kicik eded {f}");
            Console.WriteLine($"Ededi ortalari {s/n}");

        }
    }
}
