using System;

namespace ChainofResponsibility
{
    abstract class Onaylayici
    {
        protected Onaylayici ardil;
        public void ardilAta(Onaylayici ardil){
            this.ardil = ardil;
        }

        public abstract void IslemIstegi(Alim alim);

    }
    class Yonetici:Onaylayici{
        public override void IslemIstegi(Alim alim)
        {
            if(alim.Amount < 10000.0){
                Console.WriteLine("{0} onaylanan istek {1}",this.GetType().Name,alim.Number);
            }
            else if(ardil != null){
                ardil.IslemIstegi(alim);
            }
        }
    }
    class BaskanYardimcisi:Onaylayici{
        public override void IslemIstegi(Alim alim)
        {
            if(alim.Amount < 25000.0){
                Console.WriteLine("{0} onaylanan istek# {1}",this.GetType().Name,alim.Number);
            }
            else if(ardil != null){
                ardil.IslemIstegi(alim);
            }
        }
    }
    class Baskan:Onaylayici{
        public override void IslemIstegi(Alim alim)
        {
            if(alim.Amount < 100000.0){
                Console.WriteLine("{0} onaylanan istek {1}",this.GetType().Name,alim.Number);
            }
            else{
                Console.WriteLine("{0} ile toplantı yapılmalı.",alim.Number);
            }
        }
    }
    class Alim{
        private int _number;
        private double _amount;
        private string _purpose;
        public Alim(int number, int amount, string purpose){
            this._number = number;
            this._amount = amount;
            this._purpose = purpose;
        }
        public int Number {
            get {return _number;}
            set {_number = value;}
        }
        public double Amount{
            get{return _amount;}
            set{_amount = value;}
        }
        public string Purpose{
            get{return _purpose;}
            set{_purpose = value;}
        }
    }

}