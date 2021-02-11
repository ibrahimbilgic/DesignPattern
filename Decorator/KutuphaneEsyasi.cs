namespace Decorator
{
    abstract class KutuphaneEsyasi
    {
        private int _kopyaSayisi;
        public int KopyaSayisi{
            get{return _kopyaSayisi;}
            set{_kopyaSayisi = value;}
        }
        public abstract void Goster();
    }
}