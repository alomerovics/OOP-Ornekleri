using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulIfadeleri_Ornek11
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcıdan bir sayı alınız. Sayı çift ise ekrana ÇİFT değilse TEK  Turnery if kullanarak yazdırınız.
            Console.Write("Sayı Giriniz ");
            bool kontrol = int.TryParse(Console.ReadLine(), out int x);
            //int mod2 = -1;
            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("ÇİFT");
            //}
            //else
            //{
            //    Console.WriteLine("TEK");

            //}


            string durum = "";
            //durum = x % 2 == 0 ? "ÇİFT" : "TEK";
            durum = kontrol ? (x%2==0 ? "ÇİFT" : "TEK") : "LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ!!!";
            if (kontrol)
            {
                if (x % 2==0)
                {
                    Console.WriteLine("ÇİFT");

                }
                else
                {
                  Console.WriteLine("TEK");

                }
            }
            else
            {
                Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ!!!");

            }

            Console.WriteLine(durum);


            Console.ReadKey();
        }
    }
}
