
using System.Collections.Generic;
namespace FactoryMethod
{
    abstract class Belge
    {
        private List<Sayfa> _sayfalar = new List<Sayfa>();

        public Belge(){
            this.SayfaOlustur();
        }
        public List<Sayfa> Sayfalar{
            get{return _sayfalar;}
        }
        public abstract void SayfaOlustur();
    }
}