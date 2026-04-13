using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cumle daxil edin: ");
            string cumle = Console.ReadLine();

            string[] sozler = cumle.Split(' ');

            foreach (string s in sozler) {
                if (s.Length == 0) continue;
                else if (s.Length < 3) Console.WriteLine($"{s} - > qisa");
                else if (s.Length >= 3 && s.Length < 6) Console.WriteLine($"{s} - > orta");
                else Console.WriteLine($"{s} - > Uzun");
            }


        }
    }
}
