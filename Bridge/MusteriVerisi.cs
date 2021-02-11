using System;

using System.Collections.Generic;
namespace Bridge
{
    class MusteriVerisi:VeriNesnesi
    {
        private List<string> _musteriler = new List<string>();
        private int _simdiki = 0;
        public MusteriVerisi(){
            
            _musteriler.Add("Zehra Bilgiç");
            _musteriler.Add("Ozkan Yılmaz");
            _musteriler.Add("Baran Baltacı");
            _musteriler.Add("Omer Samav");
            _musteriler.Add("İbrahim Bilgiç");
        }
        public override void SonrakiKayit()
        {
            if(_simdiki <= _musteriler.Count - 1){
                _simdiki-=-1;
            }
        }
        public override void OncekiKayit()
        {
            if(_simdiki > 0){
                _simdiki += -1;
            }
        }
        public override void EkleKayit(string isim)
        {
            _musteriler.Add(isim);
        }
        public override void SilKayit(string isim)
        {
            _musteriler.Remove(isim);
        }
        public override void GosterKayit()
        {
            Console.WriteLine(_musteriler[_simdiki]);
        }
        public override void TumKayitlariGoster()
        {
            foreach (string musteri in _musteriler){
                Console.WriteLine(" "+musteri);
            }
        }

    }
}