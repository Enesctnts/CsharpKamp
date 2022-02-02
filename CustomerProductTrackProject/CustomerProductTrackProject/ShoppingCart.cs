using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProductTrack
{
    public class ShoppingCart 
    {
        public int CartId { get; set; }
        public int CustomerId { get; set; }

        public List<Product> productsList = new List<Product>();
    }
}
