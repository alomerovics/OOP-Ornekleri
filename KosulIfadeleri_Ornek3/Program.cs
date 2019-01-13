using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulIfadeleri_Ornek3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Sayı giriniz: ");
            int sayi = -1;
            bool kontrol = int.TryParse(Console.ReadLine(), out sayi);
            switch (kontrol)
            {
                case true:
                    Console.WriteLine("SAYI GİRİŞİ DOĞRU ŞEKİLDE GERÇEKLEŞTİ.");
                    break;
                case false:
                    Console.WriteLine("LÜTFEN GEÇERLİ SAYI GİRİŞİ YAPINIZ. ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
