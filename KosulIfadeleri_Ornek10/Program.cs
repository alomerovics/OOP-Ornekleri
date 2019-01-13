using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulIfadeleri_Ornek10
{
    class Program
    {
        static void Main(string[] args)
        {

            //Turnery IF // Tek Satırda If Kontrolü

            Console.Write("Sayı giriniz  :");

            bool kontrol = int.TryParse(Console.ReadLine(), out int sayi);

            string durum = "";

            durum = kontrol ? "DOĞRU" : "YANLIŞ";

            //Console.WriteLine(durum.Length > 0 ? durum  : "");
            //Console.Write(durum=="DOĞRU" ? durum : "Lütfen geçeri değer giriniz!! \n "+ DateTime.Now.ToShortDateString());

            Console.WriteLine("************durum.Length> 0 İSE *************");
            if (durum.Length> 0)
            {
                Console.WriteLine(durum);
            }
            else
            {
                Console.WriteLine("GEÇERLİ DEĞER GİRİNİZ");

            }

            Console.WriteLine("************durum==DOĞRU İSE *************");

            if (durum=="DOĞRU")
            {
                Console.WriteLine(durum);

            }
            else
            {
                Console.Write("Lütfen geçeri değer giriniz!! \n "+ DateTime.Now.ToShortDateString());

            }
            Console.ReadKey();


        }
    }
}
