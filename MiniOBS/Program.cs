using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOBS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci(1907, "Enes", "Cetintas", 54, 48, 66, "Duzce Universitesi");
            etiket:
            arayüz();
            Console.Write("Yapmak istediginiz islemi seciniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch(secim)
            {
                case 1:
                    {
                        ogrenci1.ogrbilgilerigoster();
                        Console.WriteLine("\nBaska isleme devam etmek istiyorsaniz bir sayi tusuna basiniz.");
                        Console.WriteLine("Cıkıs yapmak icin 0 a basiniz.");
                        Console.Write("Seciminiz: ");
                        int kullanicisecim = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (kullanicisecim == 0)
                        {
                            Console.WriteLine("\nCikis yapiliyor.Hoscakalin..");
                            Console.Read();
                            break;
                        }
                        else
                        {
                            goto etiket;
                            break;
                        }
                    }
                case 2:
                    {
                        double ortalama = ogrenci1.ogrortalamasibul();
                        Console.WriteLine("Ogrencinin ortalamasi: " + ortalama);
                        Console.WriteLine("Baska isleme devam etmek istiyorsaniz bir tusuna basiniz.");
                        Console.WriteLine("Cıkıs yapmak icin 0 a basiniz.");
                        Console.Write("Seciminiz: ");
                        int kullanicisecim = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (kullanicisecim == 0)
                        {
                            Console.WriteLine("Cikis yapiliyor.Hoscakalin..");
                            Console.Read();
                            break;
                        }
                        else
                        {
                            goto etiket;
                            Console.Clear();
                            break;
                        }
                    }
                case 3:
                    {
                        Console.Clear();
                        ogrenci1.okulgetir();
                        Console.WriteLine("Baska isleme devam etmek istiyorsaniz bir tusuna basiniz.");
                        Console.WriteLine("Cıkıs yapmak icin 0 a basiniz.");
                        Console.Write("Seciminiz: ");
                        int kullanicisecim = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (kullanicisecim == 0)
                        {
                            Console.WriteLine("Cikis yapiliyor.Hoscakalin..");
                            Console.Read();
                            break;
                        }
                        else
                        {;
                            goto etiket;
                            Console.Clear();
                            break;
                        }
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Yanlis Girdiniz.. Tekrar Deneyiniz..\n");
                        Console.WriteLine("Devam etmek icin bir tusa basiniz.");
                        Console.WriteLine("Cıkıs yapmak icin 0 a basiniz.");
                        Console.Write("Seciminiz: ");
                        Console.ReadLine();
                        Console.Clear();
                        int kullanicisecim = Convert.ToInt32(Console.ReadLine());

                        if (kullanicisecim == 0)
                        {
                            Console.WriteLine("Cikis yapiliyor.Hoscakalin..");
                            Console.Read();
                            break;
                        }
                        else
                        {
                            goto etiket;
                            break;
                        }
                    }
            }    
        }
        static void arayüz()
        {
            Console.WriteLine("1-Ogrenci Bilgileri");
            Console.WriteLine("2-Ogrenci Ortalamasi");
            Console.WriteLine("3-Ogrenci Okul Bilgileri");
            Console.WriteLine("4-Cıkış");


        }
    }
}
