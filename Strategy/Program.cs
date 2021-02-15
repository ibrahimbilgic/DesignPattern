using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SiraliListe ogrenciKayit = new SiraliListe();
            ogrenciKayit.Ekle("İbrahim");
            ogrenciKayit.Ekle("Zehra");
            ogrenciKayit.Ekle("Baran");
            ogrenciKayit.Ekle("Ozkan");
            ogrenciKayit.Ekle("Omer");

            ogrenciKayit.SetSiralamaStratejisi(new HizliSiralama());
            ogrenciKayit.Siralama();

            ogrenciKayit.SetSiralamaStratejisi(new KabukSiralama());
            ogrenciKayit.Siralama();

            ogrenciKayit.SetSiralamaStratejisi(new BirlestirmeliSiralama());
            ogrenciKayit.Siralama();

        }
    }
}
