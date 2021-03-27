using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Adi = "Volkan";
            customer1.Soyadi = "Torun";
            customer1.TcKimlikNo = 12345678901;
            customer1.Adresi = "Ankara";

            Customer customer2 = new Customer();
            customer2.Adi = "Nurcan";
            customer2.Soyadi = "Özbayrak";
            customer2.TcKimlikNo = 12345678901;
            customer2.Adresi = "Bursa";

            Customer customer3 = new Customer();
            customer3.Adi = "Selcan";
            customer3.Soyadi = "Özbayrak";
            customer3.TcKimlikNo = 12345678901;
            customer3.Adresi = "Eskişehir";

            CustomerManager customerManager = new CustomerManager();
            //Yeni Müşteri Ekleme
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("---------------------");
            //Müşteri Güncelleme
            customerManager.Update(customer1);
            customerManager.Update(customer2);
            customerManager.Update(customer3);
            Console.WriteLine("---------------------");
            //Müşteri Silme
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            Console.WriteLine("---------------------");
            //Müşterileri Listeleme
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            customerManager.List(customers);

            Console.ReadLine();
        }
    }
}
