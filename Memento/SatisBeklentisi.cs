using System;
namespace Memento
{
    class SatisBeklentisi
    {
        private string _isim;
        private string _telefon;
        private double _butce;

        public string Ad{
            get{return _isim;}
            set{_isim = value;
            Console.WriteLine("Adi: "+_isim);
            }
            
        }
        public string Telefon{
            get{return _telefon;}
            set{_telefon = value;
            Console.WriteLine("Telefon: "+_telefon);
            }
        }
        public double Butce{
            get{return _butce;}
            set{_butce = value;
            Console.WriteLine("Butce: "+ _butce);
            }
        }
        public Memento SaveMemento(){
            Console.WriteLine("\n Kayıt aşaması..");
            return new Memento(_isim,_telefon,_butce);
        }
        public void RestoreMemento(Memento memento){
            Console.WriteLine("Geri Yükleme durumu..");
            this.Ad = memento.Ad;
            this.Telefon = memento.Telefon;
            this.Butce = memento.Butce;
        }
    }
}