using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornek1EntityLayer.Enumlar;
using Ornek1EntityLayer.Classlar;

namespace Ornek1BussinessLayer
{
    public class KareManager
    {
        public Kare Kare { get; set; }
        public void KareOlustur(string SekilAdi, int KenarUzunlugu, SekilRenkleri Renk)
        {
            Kare = new Kare()
            {
                KenarUzunlugu = KenarUzunlugu,
                SekilAdi = SekilAdi,
                SekilRengi = Renk,
                SekilTuru = SekilTurleri.Koseli
            };
            KareyeAitBilgileriEkranaYazdir();
            KareyiCiz();
        }


        public bool KareninAdiniSor(ref string SekilAdi)
        {
            bool sonuc = false;
            Console.Write("Kare için bir şekil ismi giriniz: ");
            SekilAdi = Console.ReadLine();
            if (SekilAdi.Length > 5) //Mutlaka şekil ismi en az 6 karakter olsun.
            {
                sonuc = true;
            }
            else
            {
                throw new FormatException("Şekil adı en az 6 karakter olmalıdır!");
            }

            return sonuc;
        }

        public bool KareninUzunlugunuSor(ref int Kenar)
        {
            bool sonuc = false;
            Console.Write("Karenin bir kenar uzunluğunu giriniz:");
            bool KenarSonuc = int.TryParse(Console.ReadLine(), out Kenar);
            //negatif değer ve sıfıra dikkat!
            if (KenarSonuc) //Kullanıcı int değer girmiştir
            {
                if (Kenar <= 0)
                {
                    throw new FormatException("Lütfen kenar uzunluğu için sıfırdan büyük pozitif değer giriniz! ");
                }
                else
                {
                    sonuc = true;
                }
            }
            else
            {
                throw new FormatException("Lütfen sayısal değer giriniz! ");
            }

            return sonuc;
        }

        public bool KareninRenginiSor(ref SekilRenkleri Renk)
        {
            bool sonuc = false;
            Console.Write("Karenin rengi aşağıdaki renklerden hangisi olsun? : ");
            Console.WriteLine();
            //Enumın içindekileri ekrana yazdırmalıyız.

            //SekilRenkleri[] RenklerDizisi = Enum.GetValues(typeof(SekilRenkleri)) as SekilRenkleri[]; // Enum GetValues ile bir enum içindeki tüm değerler alınır. Bu gelen değeri CAST Yani Convert etmek gerekiyor. Neye cast/convert edeceğiz? Enum'ın tipindeki diziye! As kelimesi bu işe yarar.

            //foreach (SekilRenkleri renkItem in RenklerDizisi)
            //{
            //    Console.WriteLine(renkItem.ToString());
            //}

            //Enumların içinde hem string hem int değer var. Bu değerleri çekip bir listeye alıyoruz.
            var RenkListesi = new List<KeyValuePair<string, int>>();
            foreach (var renk in Enum.GetValues(typeof(SekilRenkleri)))
            {
                RenkListesi.Add(new KeyValuePair<string, int>(renk.ToString(), (int)renk));
            }

            //Renkler listesini ekrana yazdıralım böylece kullanıcı renkleri görecek ve seçim yapabilecek
            foreach (KeyValuePair<string, int> renk in RenkListesi)
            {
                Console.WriteLine(renk.Key + " renk için " + renk.Value.ToString() + " değerini seçiniz");
            }
            Console.WriteLine();

            Console.Write("Seçtiğiniz rengin sayı değerini giriniz: ");
            int sayiRengi = 0;
            bool sayiSonuc = int.TryParse(Console.ReadLine(), out sayiRengi);
            if (sayiSonuc)
            { //İstediğim renklere ait sayı girdi mi?
                switch (sayiRengi)
                {
                    case (int)SekilRenkleri.Siyah:
                        Renk = SekilRenkleri.Siyah;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    case (int)SekilRenkleri.Beyaz:
                        Renk = SekilRenkleri.Beyaz;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case (int)SekilRenkleri.Kirmizi:
                        Renk = SekilRenkleri.Kirmizi;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    case (int)SekilRenkleri.Mavi:
                        Renk = SekilRenkleri.Mavi;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                    default:
                        Console.WriteLine("Belirtilen değerlere göre seçim yapmadınız. Şekil rengi varsayılan olarak beyaz belirlendi");
                        Renk = SekilRenkleri.Beyaz;
                        break;
                }

            }
            else
            {
                throw new FormatException("Lütfen sayısal değer giriniz!");
            }


            return sonuc;
        }

        public void KareyiCiz()
        {
            Kare.SekilCiz();
        }

        public void KareyeAitBilgileriEkranaYazdir()
        {
            Kare.KosegenUzunluguHesapla();
        }
    }
}
