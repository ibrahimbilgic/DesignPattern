using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            string dokuman = "AAZZBBZB";
            char[] chars = dokuman.ToCharArray();

            KarakterBankasi banka = new KarakterBankasi();

            int noktaBoyutu = 10;
            foreach(char c in chars){
                noktaBoyutu -= -1; // noktaBoyutu++
                Karakter karakter = banka.GetKarakter(c);
                karakter.Goster(noktaBoyutu);
            }
        }
    }
}
