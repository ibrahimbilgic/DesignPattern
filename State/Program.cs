using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesap hesap = new Hesap("İbrahim Bilgiç");

            hesap.Kasa(500.0);
            hesap.Kasa(300.0);
            hesap.Kasa(550.0);
            hesap.FaizOde();
            hesap.ParaCek(2000.00);
            hesap.ParaCek(1100.00);
           

        }
    }
}
