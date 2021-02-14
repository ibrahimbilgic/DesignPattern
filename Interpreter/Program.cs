using System;
using System.Collections.Generic;
namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string romaRakami = "MCMXXVIII";
            Icerik icerik = new Icerik(romaRakami);

            List<Ifade> agac = new List<Ifade>();
            agac.Add(new BinlikIfade());
            agac.Add(new YuzlukIfade());
            agac.Add(new OnlukIfade());
            agac.Add(new BirlikIfade());

            foreach(Ifade ifade in agac){
                ifade.Yorumla(icerik);
            }            
            Console.WriteLine("{0} = {1}",romaRakami,icerik.Cikti);
        }
    }
}
