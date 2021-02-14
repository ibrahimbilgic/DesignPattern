using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            SohbetOdasi sohbetodasi = new SohbetOdasi();

            Katilimci ibrahim = new Beatle("İbrahim");
            Katilimci zehra = new Beatle("Zehra");
            Katilimci mehmet = new Beatle("Mehmet");
            Katilimci ayten = new Beatle("Ayten");
            Katilimci ibrahim2 = new Beatle("İbrahim2");

            sohbetodasi.Kayit(ibrahim);
            sohbetodasi.Kayit(zehra);
            sohbetodasi.Kayit(mehmet);
            sohbetodasi.Kayit(ayten);
            sohbetodasi.Kayit(ibrahim2);

            ibrahim2.Gonder("Ayten","Selam Ayten");
            zehra.Gonder("Mehmet","1 2 3 4 5");
            mehmet.Gonder("İbrahim","6 7 8  9");
            zehra.Gonder("Ayten","10 12");
            ayten.Gonder("İbrahim2","O lala");
        }
    }
}
