using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulIfadeleri_Ornek4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcıdan renk girişi alınız. (Örneğin red,blue,white...)
            //Kullanıcının giridiği renge göre Console'un arka plan rengini değiştiriniz.

            Console.Write("RENK GİRİNİZ :");
            string renk = Console.ReadLine();
            switch (renk)
            {
                case "Kırmızı":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case "Mavi":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;

                case "Sarı":
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
            }
            Console.ReadKey();
        }
    }
}
