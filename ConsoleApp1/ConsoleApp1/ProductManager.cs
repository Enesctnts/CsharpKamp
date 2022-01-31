using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerProductTrack
{
    public class ProductManager : IProductService
    {
        List<Product> _product = new List<Product>();


        public void Add(Product product)
        {

            _product.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = new Product();
            foreach (var item in _product)
            {
                if (item.ProductName == product.ProductName)
                {
                    productToDelete = item;
                    break;
                }
            }
            _product.Remove(productToDelete);
        }

        public List<Product> Listele()
        {
            return _product;
        }

        public void Update(Product product)
        {
            Product productToUpdate;
            productToUpdate = _product.SingleOrDefault(c => c.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductId = product.ProductId;
        }
    }
}
