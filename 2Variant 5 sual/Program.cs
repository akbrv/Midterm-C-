using System;
using System.Collections.Generic;
using System.Linq;

namespace _2Variant_5_sual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 3 fərqli məhsul yaradırıq
            List<ShoppingCart> mehsullar = new List<ShoppingCart>
            {
                new ShoppingCart { MehsulAdi = "Noutbuk", Qiymet = 2500.50m, Endirim = 10, ElaveEtmeVaxti = DateTime.Now },
                new ShoppingCart { MehsulAdi = "Smartfon", Qiymet = 1200.75m, Endirim = 15, ElaveEtmeVaxti = DateTime.Now },
                new ShoppingCart { MehsulAdi = "Qulaqlıq", Qiymet = -50m, Endirim = 5, ElaveEtmeVaxti = DateTime.Now } // Bilərəkdən mənfi qiymət verdik ki, yoxlamanı test edək
            };

            // 2. Ən bahalı məhsulu tapırıq (Bunun üçün LINQ kitabxanasından istifadə edirik)
            // OrderByDescending məhsulları qiymətə görə çoxdan aza doğru sıralayır, First() isə birincini (ən böyüyü) götürür.
            ShoppingCart enBahali = mehsullar.OrderByDescending(m => m.Qiymet).First();

            // 3. Nəticəni çap edirik
            Console.WriteLine("--- ƏN BAHALI MƏHSUL ---");
            Console.WriteLine($"Adı: {enBahali.MehsulAdi}");
            Console.WriteLine($"İlkin qiyməti: {enBahali.Qiymet} AZN");
            Console.WriteLine($"Endirim faizi: {enBahali.Endirim}%");
            Console.WriteLine($"Dəqiq Yekun Qiymət: {enBahali.YekunQiymet()} AZN");
            Console.WriteLine($"Yuvarlaqlaşdırılmış Qiymət: {enBahali.YuvarlaqQiymet()} AZN");

            Console.ReadLine();
        }
    }

    public class ShoppingCart
    {
        public string MehsulAdi { get; set; }

        // Qiymət xassəsi üçün yoxlama (Kapsullaşdırma)
        private decimal _qiymet;
        public decimal Qiymet
        {
            get { return _qiymet; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"Diqqət: '{MehsulAdi}' üçün qiymət mənfi ola bilməz! Qiymət 0 olaraq qəbul edildi.");
                    _qiymet = 0; // Mənfi olarsa 0 təyin edirik
                }
                else
                {
                    _qiymet = value;
                }
            }
        }

        public double Endirim { get; set; }
        public DateTime ElaveEtmeVaxti { get; set; }

        // YekunQiymet metodu
        public decimal YekunQiymet()
        {
            // Endirim məbləğini tapırıq (Qiymet * Endirim / 100)
            // 'Endirim' double olduğu üçün onu '(decimal)'-a çeviririk ki, riyazi əməliyyat aparmaq olsun
            decimal endirimMeblegi = Qiymet * (decimal)(Endirim / 100);

            return Qiymet - endirimMeblegi; // Dəqiq qiymət qaytarılır
        }

        // Math.Round() istifadə edərək 2 onluğa yuvarlaqlaşdıran metod
        public decimal YuvarlaqQiymet()
        {
            // YekunQiymet()-dən gələn nəticəni 2 onluğa qədər yuvarlaqlaşdırır
            return Math.Round(YekunQiymet(), 2);
        }
    }
}