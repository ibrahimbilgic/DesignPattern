using System;
namespace State
{
    abstract class Durum
    {
        protected Hesap hesap;
        protected double bilanco;
        protected double faiz;
        protected double altLimit;
        protected double ustLimit;

        public Hesap Hesap{
            get {return hesap;}
            set {hesap = value;}
        }
        public double Bilanco{
            get{ return bilanco;}
            set {bilanco = value;}
        }
        public abstract void Kasa(double miktar);
        public abstract void ParaCek(double miktar);
        public abstract void FaizOde();

    }
    class KirmiziDurum:Durum
    {
        private double servisUcreti;
        public KirmiziDurum(Durum durum){
            this.bilanco = durum.Bilanco;
            this.hesap = durum.Hesap;
            Baslat();
        }
        private void Baslat(){
            faiz = 0.0;
            altLimit = -100.0;
            ustLimit = 0.0;
            servisUcreti = 15.00;
        }
        public override void Kasa(double miktar){
            bilanco += miktar;
            DurumKontrolu();
        }
        public override void ParaCek(double miktar)
        {
            miktar = miktar - servisUcreti;
            Console.WriteLine("Fon kullanılabilir");
        }
        public override void FaizOde()
        {
            
        }
        private void DurumKontrolu(){
            if(bilanco > ustLimit){
                hesap.Durum = new GumusDurum(this);
            }
        }
    }
    class GumusDurum:Durum
    {
        public GumusDurum(Durum durum)
            :this(durum.Bilanco,durum.Hesap)
        {
        }
        public GumusDurum(double bilanco,Hesap hesap){
            this.bilanco = bilanco;
            this.hesap = hesap;
            Baslat();
        }
        public void Baslat(){
            faiz = 0.0;
            altLimit = 0.0;
            ustLimit = 1000.0;
        }
        public override void Kasa(double miktar)
        {
            bilanco += miktar;
            DurumKontrolu();
        }
        public override void ParaCek(double miktar)
        {
            bilanco -= miktar;
            DurumKontrolu();
        }
        public override void FaizOde()
        {
            bilanco += faiz * bilanco;
            DurumKontrolu();
        }
        private void DurumKontrolu(){
            if(bilanco < altLimit){
                hesap.Durum = new KirmiziDurum(this);
            }
            else if(bilanco > ustLimit){
                hesap.Durum = new AltinDurum(this);
            }
        }

    }
    class AltinDurum:Durum
    {
        public AltinDurum(Durum durum)
        :this(durum.Bilanco,durum.Hesap){

        }
        public AltinDurum(double bilanco,Hesap hesap){
            this.bilanco = bilanco;
            this.hesap = hesap;
            Baslat();
        }
        private void Baslat(){
            faiz = 0.05;
            altLimit = 1000.0;
            ustLimit = 1000000.0;
        }
        public override void Kasa(double miktar)
        {
            bilanco += miktar;
            DurumKontrolu();
        }
        public override void ParaCek(double miktar)
        {
            bilanco -= miktar;
            DurumKontrolu();
        }
        public override void FaizOde()
        {
            bilanco += faiz * bilanco;
            DurumKontrolu();
        }
        private void DurumKontrolu(){
            if(bilanco < 0.0){
                hesap.Durum = new KirmiziDurum(this);

            }
            else if(bilanco < altLimit){
                hesap.Durum = new AltinDurum(this);
            }
        }

    }
}