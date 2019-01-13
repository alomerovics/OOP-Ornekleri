using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulIfadeleri_Ornek7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 1-12 arasında sayı alınız. Aldığınız bu sayı değerine göre ekrana hangi mevsimde olduğumuzu yazdırınız.
            Console.Write("1-12 aralığında sayı giriniz  :");
            byte ay = 0;
            bool kontrol = byte.TryParse(Console.ReadLine(), out ay);
            if (kontrol)
            {
                switch (ay)
                {
                    case 12:
                    case 1:
                    case 2:
                        {
                            Console.WriteLine("MEVSİM: " + Mevsimler.KIS.ToString());
                            break;
                        }

                    case 3:
                    case 4:
                    case 5:
                        {
                            Console.WriteLine("MEVSİM: " + Mevsimler.ILKBAHAR.ToString());
                            break;
                        }
                    case 6:
                    case 7:
                    case 8:
                        {
                            Console.WriteLine("MEVSİM: " + Mevsimler.YAZ.ToString());
                            break;

                        }
                    case 9:
                    case 10:
                    case 11:
                        {
                            Console.WriteLine("MEVSİM: " + Mevsimler.SONBAHAR.ToString());
                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz!!");
            }
            Console.ReadKey();

        }

        public enum Mevsimler
        {
            YAZ=1,
            ILKBAHAR=2,
            SONBAHAR=3,
            KIS=4
        }
    }
}
