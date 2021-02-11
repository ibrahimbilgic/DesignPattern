using System;
namespace Decorator
{
    class Video:KutuphaneEsyasi
    {
        private string _yonetmen;
        private string _baslik;
        private int _suresi;
        public Video(string yonetmen,string baslik,int kopyaSayisi,int suresi){
            this._yonetmen = yonetmen;
            this._baslik = baslik;
            this.KopyaSayisi = kopyaSayisi;
            this._suresi = suresi;

        }
        public override void Goster()
        {
            Console.WriteLine("\nVideo ----- ");

            Console.WriteLine(" Yonetmen: {0}", _yonetmen);

            Console.WriteLine(" Baslik: {0}", _baslik);

            Console.WriteLine(" # Kopya: {0}", KopyaSayisi);

            Console.WriteLine(" Suresi: {0}\n", _suresi);
        }
    }
}