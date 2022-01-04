using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            {
                urun1.urunad = "Siyah Tayt";
                urun1.urunfiyat = 129.99;
                urun1.urunmarka = "Trendyol Milla";
            }
            Urun urun2 = new Urun();
            {
                urun2.urunad = "Swetashirt";
                urun2.urunfiyat = 259.99;
                urun2.urunmarka = "Mavi    ";
            }
            Urun urun3 = new Urun();
            {
                urun3.urunad = "Gömlek    ";
                urun3.urunfiyat = 169.99;
                urun3.urunmarka = "Lacoste";
            }
            Urun urun4 = new Urun();
            {
                urun4.urunad = "Pantolon  ";
                urun4.urunfiyat = 299.99;
                urun4.urunmarka = "Berskha";
            }
            Urun urun5 = new Urun();
            {
                urun5.urunad = "T-Shirt   ";
                urun5.urunfiyat = 99.99;
                urun5.urunmarka = "LC Waikiki";
            }

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4, urun5 };

            Console.WriteLine("Foreach Döngüsü");

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.urunad + " : " + urun.urunmarka + "  " + urun.urunfiyat);

            }

            Console.WriteLine("\nfor döngüsü\n");

            for (int i = 0; i < urunler.Length; i++)
			{
                Console.WriteLine(urunler[i].urunad + " : " + urunler[i].urunmarka + "  " + urunler[i].urunfiyat);
                
            }

            Console.WriteLine("\nWhile Döngüsü\n");
            
            int j=0;
            while(j<urunler.Length)
            {
                Console.WriteLine(urunler[j].urunad + " : " + urunler[j].urunmarka + "  " + urunler[j].urunfiyat);
                j++;
            }

            Console.ReadLine();
        }
    }
    class Urun
    {
        public string urunad { get; set; }
        public double urunfiyat { get; set; }
        public string urunmarka  { get; set; }
    }
}
