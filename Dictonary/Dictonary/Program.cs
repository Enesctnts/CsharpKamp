using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> Person = new MyDictonary<int, string>();
            Person.MyAdd(1, "Enes Çetintaş");
            Console.WriteLine("Lenght= " + Person.MyLength);
            Person.MyAdd(2, "Mikail Çetintaş");
            Person.MyAdd(3, "Samet Gergin");
            Console.WriteLine("Lenght= " + Person.MyLength);
            foreach (var values in Person.Values)
            {
                Console.WriteLine("Values: " + values);
            }
            Console.ReadLine();
        }
    }
}
