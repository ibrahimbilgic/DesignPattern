using System;
using System.Collections.Generic;
namespace Flyweight
{
    class KarakterBankasi
    {
        private Dictionary<char,Karakter> _karakter 
        = new Dictionary<char, Karakter>();

        public Karakter GetKarakter(char anahtar){
            Karakter karakter = null;

            if(_karakter.ContainsKey(anahtar)){
                karakter = _karakter[anahtar];
            }
            else{
                switch(anahtar){
                    case 'A': karakter = new KarakterA(); break;
                    case 'B': karakter = new KarakterB(); break;
                    //.
                    //.
                    //.
                    case 'Z': karakter = new KarakterZ();break;
                }
                _karakter.Add(anahtar,karakter);
            }
            return karakter;
        }
    }
    abstract class Karakter{
        protected char sembol;
        protected int  genislik;
        protected int yukseklik;
        protected int yukselis;
        protected int inis;
        protected int noktaBoyutu;
        public abstract void Goster(int noktaBoyutu);

    }
    class KarakterA:Karakter{
        public KarakterA(){
            this.sembol = 'A';
            this.genislik = 100;
            this.yukseklik = 120;
            this.yukselis = 70;
            this.inis = 0;
        }
        public override void Goster(int noktaBoyutu)
        {
            this.noktaBoyutu = noktaBoyutu;
            Console.WriteLine(this.sembol+"(nokta boyutu"+this.noktaBoyutu+")");
        }
    }
    class KarakterB:Karakter{
        public KarakterB(){
            this.sembol = 'B';
            this.genislik = 100;
            this.yukseklik = 140;
            this.yukselis = 72;
            this.inis = 0;
        }
        public override void Goster(int noktaBoyutu)
        {
            this.noktaBoyutu = noktaBoyutu;
            Console.WriteLine(this.sembol+"(nokta boyutu"+this.noktaBoyutu+")");
        }
    }
    class KarakterZ:Karakter{
        public KarakterZ(){
            this.sembol = 'Z';
            this.genislik = 100;
            this.yukseklik = 100;
            this.yukselis = 68;
            this.inis = 0;
        }
        public override void Goster(int noktaBoyutu)
        {
            this.noktaBoyutu = noktaBoyutu;
            Console.WriteLine(this.sembol+"(nokta boyutu"+this.noktaBoyutu+")");
        }
    }

}