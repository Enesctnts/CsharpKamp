using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ETradeDEMOContext : DbContext
    {
        public DbSet<Product> Product_DEMO { get; set; }
        
    }
}
