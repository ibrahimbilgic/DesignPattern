using System;

namespace Singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            Dengeleyici d1 = Dengeleyici.GetDengeleyici();
            Dengeleyici d2 = Dengeleyici.GetDengeleyici();
            Dengeleyici d3 = Dengeleyici.GetDengeleyici();
            Dengeleyici d4 = Dengeleyici.GetDengeleyici();

            if(d1 == d2 && d2 == d3 && d3 == d4){
                Console.WriteLine("Aynı Ornek");
            }
            Dengeleyici denge = Dengeleyici.GetDengeleyici();
            for(int i=0;i<15;i++){
                string server = denge.Server;
                Console.WriteLine("Gonderme isteği: "+server);
            }
        }
    }
}
