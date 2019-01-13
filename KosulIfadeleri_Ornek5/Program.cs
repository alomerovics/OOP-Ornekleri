using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulIfadeleri_Ornek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz : ");
            bool kontrol = int.TryParse(Console.ReadLine(), out int sayi);
            switch (kontrol)
            {
                case true:
                    int kalan3 = sayi % 3;
                    switch (kalan3)
                    {
                        case (int)Renkler.Beyaz:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            break;
                        case (int)Renkler.Blue:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            break;
                        case (int)Renkler.Siyah:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            break;



                        default:
                            break;
                    }
                    break;

                case false:
                    Console.WriteLine("Lütfen sayısal değer girişi yapınız!");
                    break;
            }
            Console.ReadKey();                                                  
        }
    }
    public enum Renkler
    {
        Beyaz = 0,
        Siyah = 1,
        Blue = 2
    }
}
