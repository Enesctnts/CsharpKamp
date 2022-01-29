using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeDEMOContext context = new ETradeDEMOContext())
            {
                return context.Product_DEMO.ToList();
            }
        }
        public void Add(Product product)
        {
            using (ETradeDEMOContext context = new ETradeDEMOContext())
            {
                context.Product_DEMO.Add(product);
                context.SaveChanges();

            }

        }
        public void Update(Product product)
        {
            using (ETradeDEMOContext context = new ETradeDEMOContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }

        }
        public void Delete(Product product)
        {
            using (ETradeDEMOContext context = new ETradeDEMOContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();

            }

        }


    }
}
