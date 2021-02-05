namespace AbstractFactory
{
    class AfrikaFabrikasi:KitaFabrikasi
    {
        public override Otcul OlusturOtcul(){
            return new Antilop();
        }
        public override Etcil OlusturEtcil(){
            return new Aslan();
        }
    }
}