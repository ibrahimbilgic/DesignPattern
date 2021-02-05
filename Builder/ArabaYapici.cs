namespace Builder
{
    class ArabaYapici:AracYapici
    {
        public ArabaYapici(){
            arac = new Arac("Araba");
        }
        public override void SasiYapici()
        {
            arac["sasi"] = "Araba Sasisi";
        }
        public override void MotorYapici()
        {
            arac["motor"] = "2500 cc";
        }
        public override void Tekerlekyapici()
        {
            arac["tekerlek"] = "4";
        }
        public override void KapiYapici()
        {
            arac["kapilar"] = "4";
        }
    }
}