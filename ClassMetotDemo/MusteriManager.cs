using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Tebrikler. Listeye Eklendi :  "+musteri.MusteriAdi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Listeden silindi : "+musteri.MusteriAdi);
        }
    }
}
