using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Enes Çetintaş");
            
            Console.WriteLine(isimler.Mylength);//isimler dizisinin kaç elemanı oldugunu söyler

            isimler.Add("Mikail Çetintaş");

            Console.WriteLine(isimler.Mylength);//isimler dizisinin kaç elemanı oldugunu söyler

            foreach (var isim in isimler.Items) //isimler dizisinin kişileri ekrana yazar
            {
                Console.WriteLine(isim);
            }
            Console.ReadLine();

        }
    }
}
