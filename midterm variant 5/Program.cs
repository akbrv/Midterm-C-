using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_variant__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cumle daxil edin: ");
            string cumle = Console.ReadLine();

            string[] sozler = cumle.Split(' ');

            Console.WriteLine("\nNetice");
            foreach (string e in sozler)
            {
                if (e.Length == 0) continue;
                if (e.Length < 3)
                    Console.WriteLine($"{e} -> Qisa");
                else if (e.Length >= 3 && e.Length <= 6)
                    Console.WriteLine($"{e} -> Orta");
                else Console.WriteLine($"{e} -> Uzun");

            }
        }
    }
}
