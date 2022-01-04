using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
//MusteriManager sınıfı oluşturunuz.
//Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
namespace MusteriTakip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.AdSoyad = "Enes Çetintaş";
            musteri1.yas = 25;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.AdSoyad = "Mikail Çetintaş";
            musteri2.yas = 24;

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.AdSoyad = "Samet Gergin";
            musteri3.yas = 26;

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriCıkar(musteri2);
            musteriManager.MusteriListele(musteris);
            Console.ReadLine();

        }
    }


    class Musteri
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public int yas { get; set; }


    }
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine(musteri.AdSoyad +  " kişisi listeye eklenmiştir!");
        }
        public void MusteriCıkar(Musteri musteri)
        {
            Console.WriteLine(musteri.AdSoyad + " kişisi listeden çıkarılmıştır!");
        }
        public void MusteriListele(Musteri[] musteris)
        {
            Console.WriteLine("\n------ Güncel Liste -------\n");
            foreach (var musteri in musteris)
            {
                Console.WriteLine("ID: " + musteri.ID);
                Console.WriteLine("Ad Soyad: " + musteri.AdSoyad);
                Console.WriteLine("Yaş: " + musteri.yas);
                Console.WriteLine("\n*************************");
            }

        }

    }

}
