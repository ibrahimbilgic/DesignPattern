using System;
namespace Bridge
{
    class MusteriTabani
    {
        private VeriNesnesi _veriNesnesi;
        protected string grup;
        public MusteriTabani(string grup){
            this.grup = grup;
        }
        public VeriNesnesi Veri{
            set{_veriNesnesi = value;}
            get{return _veriNesnesi;}
        }
        public virtual void Sonraki(){
            _veriNesnesi.SonrakiKayit();
        }
        public virtual void Onceki(){
            _veriNesnesi.OncekiKayit();
        }
        public virtual void Ekle(string musteri){
            _veriNesnesi.EkleKayit(musteri);
        }
        public virtual void Sil(string musteri){
            _veriNesnesi.SilKayit(musteri);
        }
        public virtual void Goster(){
            _veriNesnesi.GosterKayit();
        }
        public virtual void TumunuGoster(){
            Console.WriteLine("Musteri Grup: "+grup);
            _veriNesnesi.TumKayitlariGoster();
        }

    }
}