using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            SatisBeklentisi s = new SatisBeklentisi();
            s.Ad = "ibrahim bilgiç";
            s.Telefon ="12312313123";
            s.Butce = 25000;

            ProspectBellek bellek = new ProspectBellek();
            bellek.Memento = s.SaveMemento();


            s.Ad = "Zehra Bilgiç";
            s.Telefon ="1242134235";
            s.Butce = 30000;

            s.RestoreMemento(bellek.Memento);            
        }
    }
}
