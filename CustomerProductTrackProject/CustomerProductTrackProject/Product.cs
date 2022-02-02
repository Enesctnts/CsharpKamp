using System;
using System.Collections.Generic;
using System.Text;
using static CustomerProductTrack.CategoriesManager;

namespace CustomerProductTrack
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ProductCategory ProductCategory { get; set; }


    }
}
