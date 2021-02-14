using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IBM ibm = new IBM("IBM",120);
            ibm.Bagla(new Yatirimci("Sorros"));
            ibm.Bagla(new Yatirimci("Berkshire"));

            ibm.Fiyat=120;
            ibm.Fiyat = 121.00;
            ibm.Fiyat = 120.50;
            ibm.Fiyat = 120.75;
        }
    }
}
