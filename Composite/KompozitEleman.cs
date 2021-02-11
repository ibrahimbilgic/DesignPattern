using System;
using System.Collections.Generic;
namespace Composite
{
    class KompozitEleman:CizimElemani
    {
        private List<CizimElemani> ogeler = new List<CizimElemani>();
        public KompozitEleman(string isim)
        :base(isim)
        {
        }
        public override void Ekle(CizimElemani d)
        {
            ogeler.Add(d);
        }
        public override void Sil(CizimElemani d)
        {
            ogeler.Remove(d);
        }
        public override void Goster(int i)
        {
            Console.WriteLine(new String('-',i) +"+ " + _isim);
            foreach(CizimElemani d in ogeler){
                d.Goster(i + 2);
            }
        }
    }
}