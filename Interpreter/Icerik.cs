namespace Interpreter
{
    class Icerik
    {
        private string _girdi;
        private int _cikti;

        public Icerik(string girdi){
            this._girdi = girdi;
        }
        public string Girdi{
            get{return _girdi;}
            set{_girdi = value;}
        }
        public int Cikti{
            get{return _cikti;}
            set{_cikti = value;}
        }
    }
    abstract class Ifade{
        public void Yorumla(Icerik icerik){
            if(icerik.Girdi.Length == 0){
                return;
            }
            if(icerik.Girdi.StartsWith(Dokuz())){
                icerik.Cikti += (9 * Carpan());
                icerik.Girdi = icerik.Girdi.Substring(2);
            }
            else if(icerik.Girdi.StartsWith(Dort())){
                icerik.Cikti += (4 * Carpan());
                icerik.Girdi = icerik.Girdi.Substring(2);
            }
            else if(icerik.Girdi.StartsWith(Bes())){
                icerik.Cikti += (5 * Carpan());
                icerik.Girdi = icerik.Girdi.Substring(1);
            }
            while(icerik.Girdi.StartsWith(Bir())){
                icerik.Cikti += (1 * Carpan());
                icerik.Girdi = icerik.Girdi.Substring(1);
            }
        }
        public abstract string Bir();
        public abstract string Dort();
        public abstract string Bes();
        public abstract string Dokuz();
        public abstract int Carpan();
    }
    class BinlikIfade:Ifade{
        public override string Bir(){return "M";}
        public override string Dort(){return " ";}
        public override string Bes(){return " ";}
        public override string Dokuz(){return " ";}
        public override int Carpan(){return 1000;}
    }
    class YuzlukIfade:Ifade{
        public override string Bir(){return "C";}
        public override string Dort(){return "CD";}
        public override string Bes(){return "D";}
        public override string Dokuz(){return "CM";}
        public override int Carpan(){return 100;}
    }
    class OnlukIfade:Ifade{
        public override string Bir(){return "X";}
        public override string Dort(){return "XL";}
        public override string Bes(){return "L";}
        public override string Dokuz(){return "XC";}
        public override int Carpan(){return 10;}
    }
    class BirlikIfade:Ifade{
        public override string Bir(){return "I";}
        public override string Dort(){return "IV";}
        public override string Bes(){return "V";}
        public override string Dokuz(){return "IX";}
        public override int Carpan(){return 1;}
    }
}