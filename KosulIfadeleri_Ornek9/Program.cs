using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulIfadeleri_Ornek9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 0 ile 10 aralığında 2 tane sayı alınız. 
            //Kullanıcıdan işlem türü alınız.
            //Eğer işlem türü mod ise büyük sayının küçük sayıya modunu hesaplayınız.
            //Eğer işlem türü kuvvet al ise küçük sayının büyük sayı kadar kuvvetini hesaplayınız.
            int buyuk = -1;
            int kucuk = -1;

            Console.Write("0-10 aralığında sayı giriniz: ");
            byte sayi1 = 0;
            bool kontrol1 = Byte.TryParse(Console.ReadLine(), out sayi1);

            Console.Write("0-10 aralığında sayı giriniz :");
            byte sayi2 = 0;
            bool kontrol2 = Byte.TryParse(Console.ReadLine(), out sayi2);

            if (!kontrol1 | kontrol2 == false)
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
            }
            else if (kontrol1 & kontrol2 == true)
            {
                Console.Write("İşlem türü giriniz (MOD / KUVVET)  :");
                string islemTuru = Console.ReadLine();
                //Switch Case
                switch (islemTuru)
                {
                    case "MOD":
                        //büyük sayının küçük sayıya modu
                        if (sayi1 == sayi2)
                        {
                            Console.WriteLine("SAYILAR BİRBİRLERİNE EŞİTTİR. KALAN SIFIR ");
                        }
                        else if (sayi1 > sayi2)
                        {
                            buyuk = sayi1;
                            kucuk = sayi2;
                        }
                        else
                        {
                            buyuk = sayi2;
                            kucuk = sayi1;
                        }
                        if (buyuk > -1 & kucuk > -1)
                        {
                            int mod = buyuk % kucuk;
                            Console.WriteLine("Büyük sayının " + buyuk.ToString() + " küçük sayıya " + kucuk.ToString() + " bölümünden kalan = " + mod.ToString());
                        }
                        break;
                    case "KUVVET":
                        double sonuc = -1;
                        if (sayi1==sayi2)
                        {
                            sonuc = Math.Pow(sayi2, sayi2);
                        }
                        else if (sayi1> sayi2)
                        {
                            buyuk = sayi1;
                            kucuk = sayi2;
                        }
                        else
                        {
                            buyuk = sayi2;
                            kucuk = sayi1;
                        }
                        sonuc = Math.Pow(buyuk, kucuk);
                        if (sonuc > -1)
                        {
                            Console.WriteLine("Büyük sayının" + buyuk.ToString() +" küçük sayı " + kucuk .ToString()+ " kuvveti= " + sonuc.ToString());
                        }

                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();

        }

    }
}
