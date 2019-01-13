using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulIfadeleri_Ornek6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 1-9999 arasında değer alınız.
            //Girilen bu değeri yazıyla ekrana yazdırınız.
            //Örnek: 1400 BİN DÖRT YÜZ

            Console.Write("0-9999 aralığında sayı giriniz :");
            int sayi = 0;
            int bolum1000 = -1;
            int bolum100 = -1;
            int bolum10 = -1;

            bool kontrol = int.TryParse(Console.ReadLine(), out sayi);
            //if(kontrol==true) yerine if(kontrol) yazabiliriz.
            //if(kontrol==false) yerine if(!kontrol) yazabiliriz.

            if (kontrol & sayi <=9999)
            {
                //işlemler
                //BİNLER BASAMAĞI
                if (sayi >= 1000)
                {
                    bolum1000 = sayi / 1000; //1452 --> 1450 / 1000=1 --> bin
                    //sayi = sayi % 1000; // 1450---> 452
                    sayi = sayi - (bolum1000 * 1000);
                }
                //YÜZLER BASAMĞI
                if (sayi >= 100)
                {
                    bolum100 = sayi / 100; //--> 452 / 100 = 4 DÖRT YÜZ 
                    sayi = sayi % 100; // 452 ---> 52

                }
                //ONLAR BASAMAĞI
                if (sayi >= 10)
                {
                    bolum10 = sayi / 10; // 52 / 10 = 5 BEŞ 
                    sayi = sayi % 10; // 52 mod 10 = 2
                }
                //BİRLER BASMAĞI

                //BİNLER BASAMAĞI SWITCH CASE BLOĞU
                switch (bolum1000)
                {
                    case 1:
                        Console.Write("BİN ");
                        break;
                    case 2:
                        Console.Write(" İKİ BİN ");
                        break;
                    case 3:
                        Console.Write("ÜÇ BİN ");
                        break;
                    case 4:
                        Console.Write("DÖRT BİN ");
                        break;

                    case 5:
                        Console.Write("BEŞ BİN ");
                        break;

                    case 6:
                        Console.Write(" ALTI BİN ");
                        break;

                    case 7:
                        Console.Write("YEDİ BİN ");
                        break;

                    case 8:
                        Console.Write(" SEKİZ BİN ");
                        break;

                    case 9:
                        Console.Write("DOKUZ BİN ");
                        break;

                }

                //YÜZLER BASAMAĞI SWITCH CASE BLOĞU
                switch (bolum100)
                {
                    case 1:
                        Console.Write("YÜZ ");
                        break;
                    case 2:
                        Console.Write(" İKİ YÜZ ");
                        break;
                    case 3:
                        Console.Write("ÜÇ YÜZ ");
                        break;
                    case 4:
                        Console.Write("DÖRT YÜZ ");
                        break;

                    case 5:
                        Console.Write("BEŞ YÜZ ");
                        break;

                    case 6:
                        Console.Write(" ALTI YÜZ ");
                        break;

                    case 7:
                        Console.Write("YEDİ YÜZ");
                        break;

                    case 8:
                        Console.Write(" SEKİZ YÜZ ");
                        break;

                    case 9:
                        Console.Write("DOKUZ YÜZ ");
                        break;

                }
                //ONLAR BASAMAĞI SWITCH CASE BLOĞU
                switch (bolum10)
                {
                    case 1:
                        Console.Write("ON ");
                        break;
                    case 2:
                        Console.Write("YİRMİ ");
                        break;
                    case 3:
                        Console.Write("OTUZ ");
                        break;
                    case 4:
                        Console.Write("KIRK ");
                        break;

                    case 5:
                        Console.Write("ELLİ ");
                        break;

                    case 6:
                        Console.Write("ALTMIŞ ");
                        break;

                    case 7:
                        Console.Write("YETMİŞ");
                        break;

                    case 8:
                        Console.Write("SEKSEN");
                        break;

                    case 9:
                        Console.Write("DOKSAN ");
                        break;

                }

                if (sayi < 10)
                {
                    if (sayi!=0)
                    {
                        //BİRLER BASAMAĞI SWITCH CASE BLOĞU
                        switch (sayi)
                        {
                            case 1:
                                Console.Write("BİR ");
                                break;
                            case 2:
                                Console.Write("İKİ ");
                                break;
                            case 3:
                                Console.Write("ÜÇ ");
                                break;
                            case 4:
                                Console.Write("DÖRT ");
                                break;

                            case 5:
                                Console.Write("BEŞ ");
                                break;

                            case 6:
                                Console.Write("ALTI ");
                                break;

                            case 7:
                                Console.Write("YEDİ");
                                break;

                            case 8:
                                Console.Write("SEKİZ");
                                break;

                            case 9:
                                Console.Write("DOKUZ ");
                                break;

                        }

                    }
                    else if (sayi==0 & bolum10==-1)
                    {
                        Console.Write("SIFIR ");
                    }

                }

            }
            else
            {
                Console.WriteLine("Lütfen 1-9999 aralığında geçerli değer giriniz!!");
            }
            Console.ReadKey();

        }
    }
}
