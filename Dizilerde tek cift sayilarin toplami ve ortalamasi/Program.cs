using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizilerde_tek_cift_sayilarin_toplami_ve_ortalamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            int teksayilartoplam = 0;
            int ciftsayilartoplam = 0;

            int tekadet = 0;
            int ciftadet = 0;

            int gecici;
            
            for(int i=0; i<sayilar.Length; i++)
            {
                Console.Write( (i+1) + ". sayiyi giriniz: ");
                //gecici = Convert.ToInt32(Console.ReadLine());
                gecici = int.Parse(Console.ReadLine());
                sayilar[i] = gecici;
            }
            
            for(int i=0; i<sayilar.Length; i++)
            {
                if(sayilar[i]%2 == 0)
                {
                    ciftadet++;
                    ciftsayilartoplam += sayilar[i];
                }
                else
                {
                    tekadet++;
                    teksayilartoplam += sayilar[i];

                }
            }

            if(teksayilartoplam<ciftsayilartoplam)
            {
                Console.WriteLine("\nCift sayilarin toplami tek sayilarin toplamindan buyuktur.\n");
            }
            else
            {
                Console.WriteLine("\nTek sayilarin toplami cift sayilarin toplamından buyuktur.\n");
            }
            Console.WriteLine("****************************************\n");
            Console.WriteLine("Cift sayilarin toplami: " + ciftsayilartoplam);
            Console.WriteLine("Cift sayilarin adedi: " + ciftadet);
            Console.WriteLine("\n****************************************\n");
            Console.WriteLine("Tek sayilarin toplami: " + teksayilartoplam);
            Console.WriteLine("Tek sayilarin adedi: " + tekadet);
            Console.ReadLine();
        }
    }
}
