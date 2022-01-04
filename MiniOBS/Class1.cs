using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOBS
{
    internal class ogrenci
    {
        private int ogrno;
        private string ograd;
        private string ogrsoyad;
        private int ogrvize1;
        private int ogrvize2;
        private int ogrfinal;
        private string okulad;

        public ogrenci(int _no,string _ad,string _soyad,int _vize1,int _vize2,int _final,string _okulad)
            {
                ogrno = _no;
                ograd = _ad;
                ogrsoyad = _soyad;
                ogrvize1 = _vize1;
                ogrvize2 = _vize2;
                ogrfinal = _final;
                okulad = _okulad;
            }
        public void ogrbilgilerigoster()
        {
            Console.WriteLine("\n**** Ogrenci Bilgileri ****\n");
            Console.WriteLine("Adı ve Soyadi: " + ograd + " " + ogrsoyad);
            Console.WriteLine("Numarasi: " + ogrno);
            Console.WriteLine("vize1: " + ogrvize1 + "\nVize2: " + ogrvize2 + "\nFinal: " + ogrfinal);
            Console.WriteLine("Okul: " + okulad);
        }
        public double ogrortalamasibul()
        {
            double ortalama = ((ogrvize1 * 0.25) + (ogrvize2 * 0.35) + (ogrfinal * 0.4));
            return ortalama;
        }
        public void okulgetir()
        {
            Console.WriteLine("Ogrencinin Okulu: " + okulad);
        }

    }
}
