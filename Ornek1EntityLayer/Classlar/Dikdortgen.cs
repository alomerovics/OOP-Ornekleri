using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornek1EntityLayer.Interfaceler;

namespace Ornek1EntityLayer.Classlar
{
    public class Dikdortgen : Sekil, IKosegenli
    {

        public int KisaKenarUzunlugu { get; set; }
        public int UzunKenarUzunlugu { get; set; }

        public void KosegenUzunluguHesapla()
        {
            //Dikdörtgen için köşegen uzunluğu hesaplanacak
            //kısa kenarın karesi + uzun kenarın karesi bunların karekökü

            double KenarlarinKaresiToplami = Math.Pow(KisaKenarUzunlugu, 2) + Math.Pow(UzunKenarUzunlugu, 2);
            double KosegenSonuc = Math.Pow(KenarlarinKaresiToplami, 0.5);
            Console.WriteLine(SekilAdi + " adlı şeklin köşegen uzunluğu= " + KosegenSonuc.ToString());
        }

        public override void SekilCiz()
        {
            // Dikdörtgen çizilecek
            int[,] DikdortgenDizi = new int[KisaKenarUzunlugu, UzunKenarUzunlugu];

            for (int x = 0; x <= DikdortgenDizi.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= DikdortgenDizi.GetUpperBound(1); y++)
                {
                    // uzun kenar kadar gideceği yer burası // yani yanyana yıldız yazsın.
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
