using System;

namespace AbstractFactory
{
    class Program
    {
        public static void Main(string[] args)
        {
            KitaFabrikasi africa = new AfrikaFabrikasi();
            HayvanlarAlemi alem = new HayvanlarAlemi(africa);
            alem.BesinZinciri();

            KitaFabrikasi amerika = new AmerikaFabrikasi();
            alem = new HayvanlarAlemi(amerika);
            alem.BesinZinciri();

            Console.ReadKey();
        }
    }
}
