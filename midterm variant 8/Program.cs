using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_variant_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do {
                Console.Write("Musbet bir eded daxil  edin:");
                int.TryParse(Console.ReadLine(), out n);
            } while (n < 0);

            if (n > 20)
            {
                Console.WriteLine("Cox boyuk ededdir");

            }
            else {
                long faktorial = 1;
                for (int i = 2; i <= n; i++) { 
                    
                    faktorial *= i;

                }
                Console.WriteLine("Faktorial: " + faktorial);

            }

            int fib1 = 0;
            int fib2 = 1;
            bool fibdedir = (n == 0 || n == 1);

            while (fib2 < n) {
                int novbeti;
                novbeti = fib2 + fib1;

                fib1 = fib2;
                fib2 = novbeti;

                if(fib2==n) fibdedir = true;
            
            }

            if (fibdedir) Console.WriteLine($"{n} fibanocci sirasindadir");
            else Console.WriteLine($"{n} fibanocci sirasinda deyil");

        }
    }
}
