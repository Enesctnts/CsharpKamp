using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerProductTrack
{
    public interface ICustomerService
    {
        public void Add(Customer customer);
        public void Delete(Customer customer);
        public void Update(Customer customer);
        List<Customer> CustomerList();

    }
}
