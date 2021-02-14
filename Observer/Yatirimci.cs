using System;
namespace Observer
{
    class Yatirimci:IYatirimci
    {
        private string _isim;
        private Stok _stok;
        public Yatirimci(string isim){
            this._isim = isim;
        }
        public void Guncelle(Stok stok){
            Console.WriteLine("{0} -> {1} --> "+"{2:C}",_isim,stok.Sembol,stok.Fiyat);
        }
        public Stok Stok{
            get {return _stok;}
            set {_stok = value;}
        }
    }
}