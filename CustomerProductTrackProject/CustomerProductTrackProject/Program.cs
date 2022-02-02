using System;
using System.Collections.Generic;
using static CustomerProductTrack.CategoriesManager;

namespace CustomerProductTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            Product product1 = new Product()
            {
                ProductId = 1000,
                ProductName = "Ekmek",
                ProductCategory = ProductCategory.Gıda
            };
            productManager.Add(product1);
            

            Product product2 = new Product()
            {
                ProductId = 1001,
                ProductName = "Süt",
                ProductCategory = ProductCategory.Gıda
            };
            productManager.Add(product2);

            Product product3 = new Product()
            {
                ProductId = 1002,
                ProductName = "Şampuan",
                ProductCategory = ProductCategory.Temizlik
            };
            productManager.Add(product3);

            Product product4 = new Product()
            {
                ProductId = 1003,
                ProductName = "Şarj Aleti",
                ProductCategory = ProductCategory.elektronik
            };
            productManager.Add(product4);

            //Ürün Listeleme  customer.customerShoppingCart.productsList
            Console.WriteLine("**********Ürünler**********\n");
            foreach (var product in productManager.Listele())
            {
                Console.WriteLine("Id: " + product.ProductId + " Product: " + product.ProductName);
            }
            Console.WriteLine("\n");

            CustomerManager customerManager = new CustomerManager();
            Customer customer1 = new Customer()
            {
                CustomerId = 1,
                CustomerFirstName = "Enes",
                CustomerLastName = "Çetintaş",
                DateofBirth= new DateTime(1996, 2, 2)
            };
            customerManager.Add(customer1);

            ShoppingCart shoppingCart1 = new ShoppingCart()
            {
                CartId = 1,
                CustomerId = customer1.CustomerId
           };

            Customer customer2 = new Customer()
            {
                CustomerId = 2,
                CustomerFirstName = "Mikail",
                CustomerLastName = "Çetintaş",
                DateofBirth = new DateTime(1997, 5, 1)
            };
            customerManager.Add(customer2);

            ShoppingCart shoppingCart2 = new ShoppingCart()
            {
                CartId = 2,
                CustomerId = customer2.CustomerId
            };
            shoppingCart1.productsList.Add(product1);
            shoppingCart2.productsList.Add(product2);
            shoppingCart2.productsList.Add(product3);
            shoppingCart1.productsList.Add(product4);

            customer1.customerShoppingCart = shoppingCart1;
            customer2.customerShoppingCart = shoppingCart2;

            //Müşteri Listeleme
            Console.WriteLine("**********Müşteri Bilgileri**********\n");
            foreach (var customer in customerManager.CustomerList())
            {
                Console.WriteLine("Id: " + customer.CustomerId + "\nCustomer: " + customer.CustomerFirstName + " " + customer.CustomerLastName
                    + "\nDateofBirth: " + customer.DateofBirth + "\nShoppingCart: " + customer.customerShoppingCart.CartId);
                Console.WriteLine("\n");
            }
            

            //Müşteri Ürün Listeleme

            CustomerShoppingCartList(customer1);
            Console.WriteLine("\n");
            CustomerShoppingCartList(customer2);






            Console.ReadLine();




        }

        private static void CustomerShoppingCartList(Customer customer)
        {
            DateTime bugun = DateTime.Today;
            if (customer.DateofBirth.Day == bugun.Day && customer.DateofBirth.Month == bugun.Month)
            {

                int sayac = 1;
                Product product5 = new Product()
                {
                    ProductId = 1000,
                    ProductName = ("Çikolata").ToUpper(),
                    ProductCategory = ProductCategory.Gıda
                };
                customer.customerShoppingCart.productsList.Add(product5);
                Console.WriteLine("Doğum Gününüz Kutlu Olsun " + customer.CustomerFirstName + " Bey Bizden 1 adet " + product5.ProductName + " kazandınız.\n");
                foreach (var item in customer.customerShoppingCart.productsList)
                {
                    if (item.ProductName == ("Çikolata").ToUpper())
                    {
                        Console.WriteLine("Hediye ürün: " + item.ProductName.ToUpper());
                    }
                    else
                    {
                        Console.WriteLine(sayac + ". ürün: " + item.ProductName.ToUpper());
                    }

                    sayac++;

                }


            }
            else
            {
                int sayac = 1;
                Console.WriteLine(customer.CustomerFirstName + " Beyin Ürünleri\n");
                    foreach (var item in customer.customerShoppingCart.productsList)
                    {
                    Console.WriteLine(sayac + ". ürünüz: " + item.ProductName);
                    sayac++;
                    }
            }
        }
    }
}
