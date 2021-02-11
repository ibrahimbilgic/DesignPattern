using System;
namespace Prototype
{
    class Renk:RenkPrototipi
    {
        private int _kirmizi;
        private int _yesil;
        private int _mavi;

        public Renk(int _kirmizi,int _yesil,int _mavi){
            this._kirmizi=_kirmizi;
            this._yesil=_yesil;
            this._mavi = _mavi;
            
        }
        public override RenkPrototipi Klon()
        {
            Console.WriteLine("Klonlanan renk RGB: {0,3},{1,3},{2,3}",_kirmizi,_yesil,_mavi);
            
            return this.MemberwiseClone() as RenkPrototipi; // Yorum satırı ekle..
        }        
    }
}