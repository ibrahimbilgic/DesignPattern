using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();

            Musteri musteri = new Musteri("İbrahim Bilgiç");
            bool uygunMu = mortgage.UygunMu(musteri,125000);

            Console.WriteLine("\n"+musteri.Adi+(uygunMu ? " Onaylandı" : " Reddedildi"));
        }
    }
}
