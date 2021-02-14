using System;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Onaylayici ibrahim = new Yonetici();
            Onaylayici Ayten = new BaskanYardimcisi();
            Onaylayici Zehra = new Baskan();

            ibrahim.ardilAta(Ayten);
            Ayten.ardilAta(Zehra);

            Alim a = new Alim(2034,350,"Varliklar");
            ibrahim.IslemIstegi(a);

            a = new Alim(2035,32590,"X Projesi");
            ibrahim.IslemIstegi(a);

            a = new Alim(2036,122100,"Y Projesi");
            ibrahim.IslemIstegi(a);


        }
    }
}
