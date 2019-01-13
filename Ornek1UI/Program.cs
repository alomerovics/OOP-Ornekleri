using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ornek1BussinessLayer;
using Ornek1EntityLayer.Enumlar;

namespace Ornek1UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hangi şekli oluşturmak istersiniz? D:Dikdörtgen / K:Kare    : ");
            ConsoleKeyInfo Deger = Console.ReadKey();
            //bir satır atlasın
            Console.WriteLine();

            switch (Deger.Key)
            {
                case ConsoleKey.D:
                    {
                        DikdortgenIslemleri:
                        try
                        {
                            DikdortgenManager DManager = new DikdortgenManager();
                            int UzunKenar = 0;
                            int KisaKenar = 0;
                            DManager.DikdortgeninKenarlariniSor(ref KisaKenar, ref UzunKenar);
                            SekilRenkleri DikdortgenRengi = SekilRenkleri.Siyah;
                            DManager.DikdortgeninRenginiSor(ref DikdortgenRengi);
                            DManager.DikDortgenOlustur("Dikdortgen", KisaKenar, UzunKenar, DikdortgenRengi);
                            DManager.DikdortgenKosegenHesapla();
                            DManager.DikdortgenCiz();


                        }
                        catch (Exception Hata)
                        {
                            Console.Clear();
                            Console.WriteLine(" HATA:" + Hata.Message);
                            goto DikdortgenIslemleri;
                        }
                        break;
                    }
                case ConsoleKey.K:
                    {
                        KareIslemleri:
                        try
                        {
                            KareManager MyKaraManager = new KareManager();
                            string SeklinAdi = string.Empty;
                            MyKaraManager.KareninAdiniSor(ref SeklinAdi);
                            int KareninKenari = 0;
                            MyKaraManager.KareninUzunlugunuSor(ref KareninKenari);
                            SekilRenkleri KareninRengi = SekilRenkleri.Beyaz;
                            MyKaraManager.KareninRenginiSor(ref KareninRengi);
                            MyKaraManager.KareOlustur(SeklinAdi, KareninKenari, KareninRengi);
                        }
                        catch (Exception hata)
                        {
                            Console.Clear();
                            Console.WriteLine("HATA: " + hata.Message);
                            goto KareIslemleri;
                        }
                        break;
                    }
                default:
                    Console.WriteLine("HATA: Belirtilen seçeneklere göre değer giriniz!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
