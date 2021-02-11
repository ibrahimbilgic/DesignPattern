namespace Composite
{
    abstract class CizimElemani
    {
        protected string _isim;
        public CizimElemani(string isim){
            this._isim = isim;
        }        
        public abstract void Ekle(CizimElemani d);
        public abstract void Sil(CizimElemani d);
        public abstract void Goster(int i);
    }
}