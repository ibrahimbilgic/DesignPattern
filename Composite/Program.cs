using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            KompozitEleman kok = new KompozitEleman("Resim");
            kok.Ekle(new IlkelOge("Kırmızı cizgi"));
            kok.Ekle(new IlkelOge("Mavi Daire"));
            kok.Ekle(new IlkelOge("Yesil Kutu"));

            KompozitEleman comp = new KompozitEleman("2 Daire");
            comp.Ekle(new IlkelOge("Siyah Daire"));
            comp.Ekle(new IlkelOge("Beyaz Daire"));
            kok.Ekle(comp);

            IlkelOge ilkel = new IlkelOge("Sarı cizgi");
            kok.Ekle(ilkel);
            kok.Sil(ilkel);

            kok.Goster(1);
        }
    }
}
