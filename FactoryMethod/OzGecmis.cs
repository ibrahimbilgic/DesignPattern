namespace FactoryMethod
{
    class OzGecmis:Belge
    {
        public override void SayfaOlustur()
        {
            Sayfalar.Add(new YeteneklerSayfasi());
            Sayfalar.Add(new EgitimSayfasi());
            Sayfalar.Add(new DeneyimSayfasi());
        }
    }
}