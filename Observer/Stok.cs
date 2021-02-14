using System;
using System.Collections.Generic;
namespace Observer
{
    abstract class Stok
    {
        private string _sembol;
        private double _fiyat;
        private List<IYatirimci> _yatirimci = new List<IYatirimci>();
        public Stok(string sembol,double fiyat){
            this._sembol = sembol;
            this._fiyat = fiyat;

        }
        public void Bagla(IYatirimci yatirimci){
            _yatirimci.Add(yatirimci);
        }
        public void Ayir(IYatirimci yatirimci){
            _yatirimci.Remove(yatirimci);
        }
        public void Bildir(){
            foreach(IYatirimci yatirimci in _yatirimci){
                yatirimci.Guncelle(this);
            }
            Console.WriteLine("");
        }
        public double Fiyat{
            get{return _fiyat;}
            set{
                if(_fiyat != value){
                    _fiyat = value;
                    Bildir();
                }
            }
        }
        public string Sembol{
            get{return _sembol;}
        }
    }
}