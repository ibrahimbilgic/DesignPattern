using System;
using System.Collections.Generic;
namespace Bridge
{
    class Musteriler:MusteriTabani
    {
        public Musteriler(string grup)
        :base(grup){}

        public override void TumunuGoster()
        {
            Console.WriteLine();
            Console.WriteLine("----------------");
            base.TumunuGoster();
            Console.WriteLine("-----------------");
        }
    }
}