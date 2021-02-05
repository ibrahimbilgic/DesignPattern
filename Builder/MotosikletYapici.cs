namespace Builder
{
    class MotosikletYapici:AracYapici
    {
        public MotosikletYapici(){
            arac = new Arac("Motosiklet");

        }
        public override void SasiYapici()
        {
            arac["sasi"] = "Motosiklet Sasisi";
        }
        public override void MotorYapici()
        {
            arac["motor"] ="500 cc";
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