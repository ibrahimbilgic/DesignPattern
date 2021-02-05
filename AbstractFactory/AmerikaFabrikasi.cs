namespace AbstractFactory
{
    class AmerikaFabrikasi:KitaFabrikasi
    {
        public override Otcul OlusturOtcul()
        {
            return new Bizon();
        }
        public override Etcil OlusturEtcil()
        {
            return new Kurt();
        }
    }
}