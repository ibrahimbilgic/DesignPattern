using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            RenkYöneticisi renkYöneticisi= new RenkYöneticisi();

            renkYöneticisi["kirmizi"] = new Renk(255,0,0);
            renkYöneticisi["yesil"] = new Renk(0,255,0);
            renkYöneticisi["mavi"] = new Renk(0,0,255);

            renkYöneticisi["sinirli"] = new Renk(255,54,0);
            renkYöneticisi["huzurlu"] = new Renk(128,211,128);
            renkYöneticisi["alevli"] = new Renk(211,34,20);

            Renk renk1 = renkYöneticisi["kirmizi"].Klon() as Renk;
            Renk renk2 = renkYöneticisi["huzurlu"].Klon() as Renk;
            Renk renk3 = renkYöneticisi["alevli"].Klon() as Renk;
            
        }
    }
}
