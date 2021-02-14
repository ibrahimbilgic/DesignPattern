using System;
namespace Facade
{
    class Banka
    {
        public bool BirikimYeterliMi(Musteri musteri,int miktar){
            Console.WriteLine("Hesap kontrolü: "+musteri.Adi);
            return true;
        } 
    }
    class Kredi{
        public bool KrediMiktari(Musteri musteri){
            Console.WriteLine("Kredi Kontrolü: "+musteri.Adi);
            return true;
        }
    }
    class Borclanma{
        public bool BorclanmaUygunMu(Musteri musteri){
            Console.WriteLine("Borclanma kontrolü: "+musteri.Adi);
            return true;
        }
    }
    class Musteri{
        private string _adi;
        public Musteri(string adi){
            this._adi=adi;
        }
        public string Adi{
            get{return _adi;}
        }
    }
    class Mortgage{
        private Banka _banka = new Banka();
        private Borclanma _borclanma = new Borclanma();
        private Kredi _kredi = new Kredi();

        public bool UygunMu(Musteri musteri,int miktar){
            Console.WriteLine("{0} için {1:C} gereklidir\n",musteri.Adi,miktar);
            bool uygunMu = true;

            if(!_banka.BirikimYeterliMi(musteri,miktar)){
                uygunMu = false;
            }
            else if(!_borclanma.BorclanmaUygunMu(musteri)){
                uygunMu = false;
            }
            else if(!_kredi.KrediMiktari(musteri)){
                uygunMu = false;
            }
            return uygunMu;
        }
    }
}