using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProductTrack
{
    public interface IProductService
    {
        public void Add(Product product);
        public void Delete(Product product);
        public void Update(Product product);
        List<Product> Listele();

    }
}
