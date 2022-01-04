using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMmini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            Console.WriteLine("**** ATM Hoş geldiniz ****\n");
        etiket:
            Console.WriteLine("1-Bakiye Gorüntuleme\n2-Para Cekme\n3-Para Yatirma\n4-Cikis\n");
            Console.Write("isleminizi seciniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    {
                        Console.WriteLine("\nBakiyeniz: " + bakiye + "\n");
                        Console.Write("Devam etmek icin bir tusa basiniz.");
                        Console.ReadLine();
                        Console.Clear();
                        goto etiket;
                        break;
                    }
                case 2:
                    {
                    etiket2:
                        Console.WriteLine("\nBakiyeniz: " + bakiye);
                        Console.Write("Ne kadar para cekimi yapicaksiniz: ");
                        int cekim = Convert.ToInt32(Console.ReadLine());

                        if (cekim <= bakiye)
                        {
                            bakiye = bakiye - cekim;
                            Console.WriteLine("Kalan Bakiyeniz: " + bakiye + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Bakiyeniz yetersiz..Tekrar Deneyiniz..");
                            goto etiket2;
                        }

                        Console.Write("Devam etmek icin bir tusa basiniz.");
                        Console.ReadLine();
                        Console.Clear();
                        goto etiket;
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nBakiyeniz: " + bakiye);
                        Console.Write("Yatircaginiz tutari giriniz: ");
                        int yatirma = Convert.ToInt32(Console.ReadLine());
                        bakiye = bakiye + yatirma;
                        Console.WriteLine("Güncel Bakiyeniz: " + bakiye + "\n");
                        Console.Write("Devam etmek icin bir tusa basiniz.");
                        Console.ReadLine();
                        Console.Clear();
                        goto etiket;
                        break;
                    }

                case 4:
                    {
                        Console.Clear();
                        Console.Write("Cikis yapiliyor, Hoscakalin.\nEkranin kapanmasi icin bir tusa basiniz..\n\n");
                        Console.ReadLine();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Yanlis islem yaptiniz..Tekrar Deneyiniz..");
                        Console.WriteLine("Devam etmek icin bir tusa basiniz.");
                        Console.ReadLine();
                        Console.Clear();
                        goto etiket;
                    }
            }

        }
    }
}

