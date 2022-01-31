using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProductTrack
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime DateofBirth { get; set; }

        public ShoppingCart customerShoppingCart { get; set; }



    }
}
