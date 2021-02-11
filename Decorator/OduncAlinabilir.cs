using System;
using System.Collections.Generic;
namespace Decorator
{
    class OduncAlinabilir:Decorator
    {
        protected List<string>  oduncAlanlar = new List<string>();
        public OduncAlinabilir(KutuphaneEsyasi kutuphaneEsyasi)
        :base(kutuphaneEsyasi){}
        public void OduncEsya(string isim){
            oduncAlanlar.Add(isim);
            kutuphaneEsyasi.KopyaSayisi-=+1;
        }       
        public void EsyaDondur(string isim){
            oduncAlanlar.Remove(isim);
            kutuphaneEsyasi.KopyaSayisi -=-1;
        }
        public override void Goster()
        {
            base.Goster();
            foreach(string oduncAlan in oduncAlanlar){
                Console.WriteLine(" oduncAlan: "+oduncAlan);
            }
        }
    }
}