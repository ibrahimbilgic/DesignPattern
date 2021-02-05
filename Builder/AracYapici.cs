namespace Builder
{
    abstract class AracYapici
    {
        protected Arac arac;

        public Arac Arac{
            get{return arac;}
        }

        public abstract void SasiYapici();
        public abstract void MotorYapici();
        public abstract void Tekerlekyapici();
        public abstract void KapiYapici();
    }
}