using System;

namespace Mifterm
{
    internal class Program
    {
        static void Main(string[] args, int h1)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            int b = 0, c = 0, d = 0;

            while (a >= 10)
            {
                c = 0;
                d = a;

                while (d > 0)
                {
                    b = d % 10;
                    c = c + b;
                    d = d / 10;
                }

                a = c;

                Console.WriteLine(a);



            }
        }
    }
}