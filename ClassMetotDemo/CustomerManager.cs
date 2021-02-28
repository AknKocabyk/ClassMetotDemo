using System;
using System.Collections.Generic;
using System.Text;


namespace ClassMetotDemo
{
    class CustomerManager
    {
        
        public void MusteriEkle(Customer musteri)
        {
            Console.WriteLine("Oyuncu Eklendi!");
            Console.WriteLine(" ");
            Console.WriteLine("Adı: " + musteri.Ad);
            Console.WriteLine("Soyadı: " + musteri.SoyAd);
            Console.WriteLine("FormaNo: " + musteri.FormaNo);
            Console.WriteLine("Telefon Numarası: " + musteri.TelefonNo);
            Console.WriteLine("-----------------------");
             
        }
        public void MusteriListele()
        {
            Console.WriteLine("Oyuncular Listeleniyor");

            List<Customer> customers = new List<Customer>();
            foreach (var musteri in customers)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.SoyAd + " " + musteri.FormaNo + " " + musteri.TelefonNo);
            }
            Console.WriteLine("-----------------------");

        }
        public void MusteriSil(Customer musteri)
        {
            Console.WriteLine("Oyuncu Kaydı Silindi!");
            Console.WriteLine(musteri.Ad + " "+ musteri.SoyAd + " " + musteri.FormaNo + " " + musteri.TelefonNo);
            Console.WriteLine("-----------------------");

        }
    }
}
