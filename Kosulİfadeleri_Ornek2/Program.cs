using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosulİfadeleri_Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcıdan 1-7 arasında sayı alınız. Kullanıcının girdiği sayıya göre haftanın hangi gününde olduuğumuzu ekrana yazınız.
            Console.Write("1-7 aralığında sayı giriniz.");
            byte gun = 0;
            bool gunKontrol = byte.TryParse(Console.ReadLine(), out gun);
            switch(gun)
            {
                case 1:
                    Console.WriteLine("PAZARTESİ :( ");
                    break;
                case 2: Console.WriteLine("SALI"); break;
                case 3:
                    Console.WriteLine("ÇARŞAMBA ");
                    break;
                case 4:
                    Console.WriteLine("PERŞEMBE ");
                    break;
                case 5:
                    Console.WriteLine("CUMA YUPPİ :) ");
                    break;
                case 6:
                    Console.WriteLine("CUMARTESİ YUPPİ :) ");
                    break;
                case 7:
                    Console.WriteLine("PAZAR YUPPİ :) ");
                    break;
                default:
                    Console.WriteLine("UYARI: 1-7 arasında değer girmeniz gerekiyor!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
