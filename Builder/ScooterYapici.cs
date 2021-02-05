namespace Builder
{
    class ScooterYapici:AracYapici
    {
        public ScooterYapici(){
            arac = new Arac("Scooter");
        }
        public override void SasiYapici()
        {
            arac["sasi"] = "Scooter sasisi";
        }
        public override void MotorYapici()
        {
            arac["motor"] = "50 cc";
        }
        public override void Tekerlekyapici()
        {
            arac["tekerlek"] = "2";
        }
        public override void KapiYapici()
        {
            arac["kapilar"] = "0";
        }
    }
}