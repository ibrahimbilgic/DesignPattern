using System;
using System.Collections.Generic;
namespace Composite
{
    class IlkelOge:CizimElemani
    {
        public IlkelOge(string isim)
        :base(isim)
        {
        }

        public override void Ekle(CizimElemani c)
        {
            Console.WriteLine(" ilkel eleman eklenemedi");
        }
        public override void Sil(CizimElemani c)
        {
            Console.WriteLine("ilkel oge silinemedi");
        }
        public override void Goster(int i)
        {
            Console.WriteLine(new String('-',i)+" "+_isim);
        }
    }
}