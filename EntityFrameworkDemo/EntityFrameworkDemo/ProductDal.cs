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
        public List<Product> GetByName(string key)
        {
            using (ETradeDEMOContext context = new ETradeDEMOContext())
            {
                return context.Product_DEMO.Where(p=>p.Name.Contains(key)).ToList();
            }
        }
        public List<Product> GetByUnitPriceMin(decimal min)
        {
            using (ETradeDEMOContext context = new ETradeDEMOContext())
            {
                var result5= context.Product_DEMO.Where(p => p.UnitPrice>=min).ToList();
                return result5;
            }
        }
        public List<Product> GetByUnitPriceMax(decimal max)
        {
            using (ETradeDEMOContext context = new ETradeDEMOContext())
            {
                var result6= context.Product_DEMO.Where(p => p.UnitPrice <= max).ToList();
                return result6;
            }
        }
        public Product GetById(int id)
        {
            using (ETradeDEMOContext context = new ETradeDEMOContext())
            {
                var result = (context.Product_DEMO.FirstOrDefault(p=>p.Id==id));
                return result;
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
