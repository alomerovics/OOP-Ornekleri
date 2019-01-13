using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornek1EntityLayer.Classlar;
using Ornek1EntityLayer.Enumlar;

namespace Ornek1BussinessLayer
{
    public class DikdortgenManager
    {
        public Dikdortgen Dikdortgen { get; set; }
        public void DikDortgenOlustur(string DikdortgenAdi, int KisaKenar, int UzunKenar, SekilRenkleri DikDortgenRengi)
        {
            Dikdortgen = new Dikdortgen()
            {
                KisaKenarUzunlugu = KisaKenar,
                UzunKenarUzunlugu = UzunKenar,
                SekilAdi = DikdortgenAdi,
                SekilRengi = DikDortgenRengi,
                SekilTuru = SekilTurleri.Koseli

            };
        }

        public bool DikdortgeninKenarlariniSor(ref int KisaKenar, ref int UzunKenar)
        {
            bool sonuc = false;
            Console.Write("Kısa kenarın degerini giriniz: ");
            bool KisaKenarSonuc = int.TryParse(Console.ReadLine(), out KisaKenar);

            Console.Write("Uzun kenarın degerini giriniz: ");
            bool UzunKenarSonuc = int.TryParse(Console.ReadLine(), out UzunKenar);
            if (KisaKenarSonuc == true & UzunKenarSonuc == true)
            {
                //kısa kenar ve uzun kenar eşit olamaz.
                //kısa kenar uzunkenardan daha küçük değere sahip olması lazım
                if (KisaKenar >= UzunKenar)
                {
                    throw new FormatException("Kısa kenar uzun kenardan küçük değere sahip olmalıdır ");

                }
                else if (KisaKenar <= 0 | UzunKenar <= 0)
                {
                    throw new FormatException("kenar degerleri sıfırdan buyuk pozitif deger olamlıdır. ");
                }
                else
                {
                    sonuc = true;
                }


            }
            else
            {
                throw new FormatException("Hata: Lütfen sayısal değer giriniz! ");
            }

            return sonuc;

        }

        public void DikdortgeninRenginiSor(ref SekilRenkleri DikdortgenRengi)
        {
            List<KeyValuePair<string, int>> Renkler = new List<KeyValuePair<string, int>>();
            foreach (var item in Enum.GetValues(typeof(SekilRenkleri)))
            {
                Renkler.Add(new KeyValuePair<string, int>(item.ToString(), (int)item));
            }
            foreach (KeyValuePair<string, int> renkPair in Renkler)
            {
                Console.WriteLine(renkPair.Key + " rengi için " + renkPair.Value.ToString() + " değerini giriniz.");
            }

            Console.Write("Seçtiğiniz rengin sayı değerini giriniz: ");
            int sayiRengi = 0;
            bool sayiSonuc = int.TryParse(Console.ReadLine(), out sayiRengi);
            if (sayiSonuc)
            { //İstediğim renklere ait sayı girdi mi?
                switch (sayiRengi)
                {
                    case (int)SekilRenkleri.Siyah:
                        DikdortgenRengi = SekilRenkleri.Siyah;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case (int)SekilRenkleri.Beyaz:
                        DikdortgenRengi = SekilRenkleri.Beyaz;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case (int)SekilRenkleri.Kirmizi:
                        DikdortgenRengi = SekilRenkleri.Kirmizi;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case (int)SekilRenkleri.Mavi:
                        DikdortgenRengi = SekilRenkleri.Mavi;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    default:
                        Console.WriteLine("Belirtilen değerlere göre seçim yapmadınız. Şekil rengi varsayılan olarak beyaz belirlendi");
                        DikdortgenRengi = SekilRenkleri.Beyaz;
                        break;
                }

            }
            else
            {
                throw new FormatException("Lütfen sayısal değer giriniz!");
            }




        }

        public void DikdortgenCiz()
        {
            Dikdortgen.SekilCiz();



        }
        public void DikdortgenKosegenHesapla()
        {
            Dikdortgen.KosegenUzunluguHesapla();

        }
    }
}
