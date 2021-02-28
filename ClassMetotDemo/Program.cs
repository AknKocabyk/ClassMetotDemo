using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FormaNo = 31;
            customer1.Ad = "Mostafa";
            customer1.SoyAd = "Mohammed";
            customer1.TelefonNo = "0521312412";
           

            Customer customer2 = new Customer();
            customer2.FormaNo = 1;
            customer2.Ad= "Fernando";
            customer2.SoyAd = "Muslera";
            customer2.TelefonNo = "0531234312";

            CustomerManager customerManager = new CustomerManager();

            customerManager.MusteriEkle(customer1);
            customerManager.MusteriEkle(customer2);
            customerManager.MusteriListele();


            customerManager.MusteriSil(customer1);
            customerManager.MusteriListele();

        }
    }

}
