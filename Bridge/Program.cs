using System;
using System.Collections.Generic;
namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteriler = new Musteriler("Türkiye");

            musteriler.Veri = new MusteriVerisi();
            musteriler.Goster();
            musteriler.Sonraki();
            musteriler.Goster();
            musteriler.Sonraki();
            musteriler.Goster();
            musteriler.Ekle("İbrahim 2 eklendi..");

            musteriler.TumunuGoster();
        }
    }
}
