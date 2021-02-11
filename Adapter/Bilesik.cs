using System;
namespace Adapter
{
    class Bilesik
    {
        protected string _kimyasal;
        protected float _kaynamaNoktasi;
        protected float _erimeNoktasi;
        protected double _molekulerAgirlik;
        protected string _molekulerFormul;

        public Bilesik(string _kimyasal){
            this._kimyasal = _kimyasal;
        }
        public virtual void Goster(){
            Console.WriteLine("\n Bilesik: {0} -----",_kimyasal);
        }

    }
}