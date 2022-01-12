using InterfaceAbstractDemoProje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemoProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
                {
                    DateOfBirth = new System.DateTime(1996, 6, 1),
                    FirsName = "Enes",
                    LastName = "Çetintaş",
                    NationalityId = "10161102260",
                    Id = 1
                });

            Console.ReadLine();
        }

    }
}
