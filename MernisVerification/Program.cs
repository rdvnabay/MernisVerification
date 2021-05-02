using MernisVerification.Concrete;
using MernisVerification.Entities;
using System;

namespace MernisVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Rıdvan",
                LastName = "Abay",
                DateOfYear =1993,
                NationalIdentity = "12345678901"
            };
            customerManager.Add(customer);
            Console.ReadLine();
        }
    }
}
