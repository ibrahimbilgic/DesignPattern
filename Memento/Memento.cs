namespace Memento
{
    class Memento
    {
        private string _isim;
        private string _telefon;
        private double _butce;

        public Memento(string isim,string telefon, double butce){
            this._isim = isim;
            this._telefon = telefon;
            this._butce = butce;
        }        
        public string Ad{
            get{return _isim;}
            set{_isim = value;}
        }
        public string Telefon{
            get{return _telefon;}
            set{_telefon =value;}
        }
        public double Butce{
            get{return _butce;}
            set{_butce = value;}
        }
    }
    class ProspectBellek
    {
        private Memento _memento;
        public Memento Memento{
            set{_memento = value;}
            get{return _memento;}
        }
    }
}