using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_variant_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            

            if (a > 0) {
                Console.WriteLine($"{a} Musbet ededdir");
            
            }
            else if(a < 0){
                Console.WriteLine($"{a} Menfi ededdir");
            }
            else {Console.WriteLine($"{a} Sifirdir"); }
            

            if (a >= 2) {
                for (int i = 2; i <= a; i++) {
                    int g = 0;
                    for (int j = 2; j < i; j++) {
                        if (i % j == 0) {
                            g += 1;
                        }
                    }
                    if (g == 0) {
                        Console.WriteLine(i);
                    }
                                    
                }
            
            }
        }
    }
}
