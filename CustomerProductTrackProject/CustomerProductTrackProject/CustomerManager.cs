using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CustomerProductTrack.CategoriesManager;

namespace CustomerProductTrack
{
    public class CustomerManager : ICustomerService
    {
        List<Customer> _customers = new List<Customer>();
        List<Product> _customersShoppingCart = new List<Product>();

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Delete(Customer customer)
        {
            Customer customerToDelete = new Customer();
            foreach (var item in _customers)
            {
                if (item.CustomerFirstName == customer.CustomerFirstName)
                {
                    customerToDelete = item;
                    break;
                }
            }
            _customers.Remove(customerToDelete);
        }

        public List<Customer> CustomerList()
        {
            return _customers;
        }



        public void Update(Customer customer)
        {
            Customer customerToUpdate;
            customerToUpdate = _customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId);
            customerToUpdate.CustomerFirstName = customer.CustomerFirstName;
            customerToUpdate.CustomerId = customer.CustomerId;
        }

        
    }
}
