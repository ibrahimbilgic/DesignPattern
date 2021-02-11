namespace FactoryMethod
{
    class Raporla:Belge
    {
        public override void SayfaOlustur()
        {
            Sayfalar.Add(new TanitimSayfasi());
            Sayfalar.Add(new SonucSayfasi());
            Sayfalar.Add(new NeticeSayfasi());
            Sayfalar.Add(new SonucSayfasi());
            Sayfalar.Add(new OzetSayfasi());
            Sayfalar.Add(new KaynakcaSayfasi());
        }
    }
}