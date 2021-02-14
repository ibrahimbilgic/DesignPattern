using System;
namespace State
{
    class Hesap
    {
        private Durum _durum;
        private string _sahip;

        public Hesap(string sahip){
            this._sahip = sahip;
            this._durum = new GumusDurum(0.0,this);
        }
        public double Bilanco{
            get{return _durum.Bilanco;}
        }

        public Durum Durum{
            get{return _durum;}
            set{_durum = value;}
        }

        public void Kasa(double miktar){
            _durum.Kasa(miktar);
            Console.WriteLine("Yatırdı {0:C} --- ", miktar);
            Console.WriteLine(" Bilanco = {0:C}", this.Bilanco);
            Console.WriteLine(" Durum = {0}",this.Durum.GetType().Name);
            Console.WriteLine("");
        }
        public void ParaCek(double miktar){
             _durum.ParaCek(miktar);
            Console.WriteLine("Para çekildi {0:C} --- ", miktar);
            Console.WriteLine(" Bilanco = {0:C}", this.Bilanco);
            Console.WriteLine(" Durum = {0}\n",this.Durum.GetType().Name);
        }
        public void FaizOde(){
             _durum.FaizOde();
            Console.WriteLine("Odenen Faiz --- ");
            Console.WriteLine(" Bilanco = {0:C}", this.Bilanco);
            Console.WriteLine(" Durum = {0}\n",this.Durum.GetType().Name);
        }

    }
}