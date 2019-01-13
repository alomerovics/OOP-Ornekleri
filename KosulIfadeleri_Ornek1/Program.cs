using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulIfadeleri_Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Switch Case
            //Kullanıcıdan bir sayı alınız. Kullanıcının girişi doğru yapıp yapmadığını switch case ile kontrol ediniz.
            Console.Write("Sayı giriniz : ");
            int sayi = 0;
            bool kontrol = int.TryParse(Console.ReadLine(), out sayi);

            switch (sayi)
            {
                case 0:
                    {
                        Console.WriteLine("SIFIR");
                        break;
                    }
                case 50:
                    {
                        Console.WriteLine("ELLİ");
                        break;
                    }
                case 150:
                    {
                        Console.WriteLine("YÜZ ELLİ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("SIFIR VE ELLİ DIŞINDA BİR SAYI GİRDİNİZ.");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
