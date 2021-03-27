using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Adi + " " + customer.Soyadi + " : Added");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Adi + " " + customer.Soyadi + " : Updated");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Adi + " " + customer.Soyadi + " : Deleted");
        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Adi + " " + customer.Soyadi);
            }
        }
    }
}
