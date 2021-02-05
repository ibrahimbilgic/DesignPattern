namespace AbstractFactory
{
    class HayvanlarAlemi
    {
        private Otcul _otcul;
        private Etcil _etcil;

        //Yapıcı
        public HayvanlarAlemi(KitaFabrikasi fabrika){
            _etcil = fabrika.OlusturEtcil();
            _otcul = fabrika.OlusturOtcul();
        }
        public void BesinZinciri(){
            _etcil.Yer(_otcul);
        }
    }
}