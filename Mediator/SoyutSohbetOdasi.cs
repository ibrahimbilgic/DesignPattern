using System;
using System.Collections.Generic;
namespace Mediator
{
    abstract class SoyutSohbetOdasi
    {
        public abstract void Kayit(Katilimci katilimci);
        public abstract void Gonder(string from, string to, string mesaj);
    }
    class SohbetOdasi:SoyutSohbetOdasi{
        private Dictionary<string,Katilimci> _katilimcilar =
            new Dictionary<string, Katilimci>();

        public override void Kayit(Katilimci katilimci)
        {
            if(!_katilimcilar.ContainsValue(katilimci)){
                _katilimcilar[katilimci.Name] = katilimci;
            }
            katilimci.SohbetOdasi = this;
        }
        public override void Gonder(string from, string to, string mesaj)
        {
            Katilimci katilimci = _katilimcilar[to];
            if(katilimci != null){
                katilimci.Al(from,mesaj);
            }
        }
    }
    class Katilimci{
        private SohbetOdasi _sohbetodasi;
        private string _isim;

        public Katilimci(string isim){
            this._isim = isim;
        }
        public string Name{
            get{return _isim;}
        }
        public SohbetOdasi SohbetOdasi{
            set{_sohbetodasi = value;}
            get{ return _sohbetodasi;}
        }
        public void Gonder(string to,string mesaj){
            _sohbetodasi.Gonder(_isim,to,mesaj);
        }
        public virtual void Al(string from,string mesaj){
            Console.WriteLine("{0} to {1}: {2}",from,Name,mesaj);
        }
    }
    class Beatle:Katilimci{
        public Beatle(string isim):base(isim){
        }
        public override void Al(string from, string mesaj)
        {
            Console.Write("To a Beatle ");
            base.Al(from, mesaj);
        }
    }
    class NonBeatle:Katilimci{
        public NonBeatle(string isim):base(isim){

        }
        public override void Al(string from, string mesaj)
        {
            Console.Write("To a non-Beatle ");
            base.Al(from, mesaj);
        }
    }
}