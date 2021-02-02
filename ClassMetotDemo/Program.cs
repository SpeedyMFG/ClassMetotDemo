using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Haktan";
            musteri1.MusteriSoyadi = "Tanrıkulu";
            musteri1.MusteriMemleket = "Bayburt";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Muhammet Furkan";
            musteri2.MusteriSoyadi = "Gün";
            musteri2.MusteriMemleket = "Muş";            

            Musteri[] musteriler = new Musteri[] { musteri2, musteri1 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.MusteriMemleket);
                Console.WriteLine("-----------------------------");


            }



        }
    }
}
