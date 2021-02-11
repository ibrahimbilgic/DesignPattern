using System;
namespace Decorator
{
    class Kitap:KutuphaneEsyasi
    {
        private string _yazar;
        private string _baslik;

        public Kitap(string yazar,string baslik,int kopyaSayisi){
            this._yazar = yazar;
            this._baslik = baslik;
            this.KopyaSayisi = kopyaSayisi;
        }
        public override void Goster()
        {
        Console.WriteLine("\nKitap ------ ");

        Console.WriteLine(" Yazar: {0}", _yazar);

        Console.WriteLine(" Baslik: {0}", _baslik);

        Console.WriteLine(" # Kopya: {0}", KopyaSayisi);
        }
    }
}