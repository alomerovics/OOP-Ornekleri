using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornek1EntityLayer.Interfaceler;

namespace Ornek1EntityLayer.Classlar
{
    public class Kare : Sekil, IKosegenli
    {
        public int KenarUzunlugu { get; set; }

        public void KosegenUzunluguHesapla()
        {
            //Karenin köşegen uzunluğu hesaplanacak
            // n kenar için n * kök2  ile köşegen uzunluğu hesaplanır
            double kok2 = Math.Pow(2, 0.5);
            double KosegenSonuc = KenarUzunlugu * kok2;
            Console.WriteLine(SekilAdi + " adlı şeklin köşegen uzunluğu= " + KosegenSonuc.ToString());

        }

        public override void SekilCiz()
        {
            //Kare çizilecek
            //Şekli çizmeden önce rengini ayarlamamız lazım!

            int[,] KareDizi = new int[KenarUzunlugu, KenarUzunlugu];
            for (int x = 0; x <= KareDizi.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= KareDizi.GetUpperBound(1); y++)
                {
                    //Yanyana yıldız yazacak
                    Console.Write(" * ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
