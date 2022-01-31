using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProductTrack
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public static implicit operator Category(List<Category> v)
        {
            throw new NotImplementedException();
        }
    }
}
