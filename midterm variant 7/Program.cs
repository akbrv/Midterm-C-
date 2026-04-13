using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_variant_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bal;

            do {
                Console.WriteLine("1-100 arasi bir ededn secin ");
                int.TryParse(Console.ReadLine(), out bal);

            } while (bal < 0 || bal > 100);

            string herfiqiymet;
            if (bal >= 90) herfiqiymet = "A";
            else if (bal >= 80) herfiqiymet = "B";
            else if (bal >= 70) herfiqiymet = "C";
            else if (bal >= 60) herfiqiymet = "D";
            else if (bal >= 51) herfiqiymet = "E";
            else herfiqiymet = "F";

            Console.WriteLine("Herfi Qiymetiniz: " + herfiqiymet);

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{bal} x {i} = {bal * i}");

            }



        }
    }
}
