namespace Decorator
{
    abstract class Decorator:KutuphaneEsyasi
    {
        
        protected KutuphaneEsyasi kutuphaneEsyasi;
        public Decorator(KutuphaneEsyasi kutuphaneEsyasi){
            this.kutuphaneEsyasi = kutuphaneEsyasi;
        }
        public override void Goster()
        {
            kutuphaneEsyasi.Goster();            
        }
    }
}