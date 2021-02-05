using System;
using System.Collections.Generic;
namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AracYapici yapici;

            Magaza mgz = new Magaza();

            yapici = new ScooterYapici();
            mgz.Yapici(yapici);
            yapici.Arac.Goster();

            yapici = new ArabaYapici();
            mgz.Yapici(yapici);
            yapici.Arac.Goster();

            yapici = new MotosikletYapici();
            mgz.Yapici(yapici);
            yapici.Arac.Goster();

            //Console.ReadKey();
        }
    }
}
