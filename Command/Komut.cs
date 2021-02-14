using System;
using System.Collections.Generic;
namespace Command
{
    abstract class Komut
    {
        public abstract void Calistir();
        public abstract void Calistirma();      
    }
    class HesaplaKomutu:Komut{
        private char _operator;
        private int _operand;
        private HesapMakinesi _hesapmakinesi;
        public HesaplaKomutu(HesapMakinesi hesapMakinesi,char @operator,int operand){
            this._hesapmakinesi = hesapMakinesi;
            this._operator = @operator;
            this._operand = operand;
        }
        public char Operator{
            set{_operator = value;}
        }
        public int Operand{
            set{_operand = value;}
        }
        public override void Calistir()
        {
            _hesapmakinesi.Operasyon(_operator,_operand);
        }
        public override void Calistirma()
        {
            _hesapmakinesi.Operasyon(Ac(_operator),_operand);
        }
        private char Ac(char @operator){
            switch(@operator){
                case '+':return '-';
                case '-':return '+';
                case '*':return '/';
                case '/':return '*';
                default : throw new ArgumentException("@operator");

            }
        }
    }
    class HesapMakinesi{
        private int suanki=0;

        public void Operasyon(char @operator,int operand){
            switch(@operator){
                case '+':suanki+=operand;break;
                case '-':suanki-=operand;break;
                case '*':suanki*=operand;break;
                case '/':suanki/=operand;break;
            }
            Console.WriteLine("Su anki deger = {0,3}(izlenen islem: {1} {2})",suanki,@operator,operand);
        }
    }
    class Kullanici{
        private HesapMakinesi _hesapmakinesi = new HesapMakinesi();
        private List<Komut> _komutlar = new List<Komut>();
        private int _suan = 0;

        public void tekrarla(int seviyeler){
            Console.WriteLine("\n--- {0} seviye yineleniyor..",seviyeler);

            for(int i=0; i<seviyeler;i++){
                if(_suan <_komutlar.Count -1 ){
                    Komut komut = _komutlar[_suan++];
                    komut.Calistir();
                }
            }
        }
        public void Ac(int seviye){
            Console.WriteLine("\n --- {0} seviye aciliyor...",seviye);
            for(int i=0;i<seviye;i++){
                if(_suan > 0){
                    Komut komut = _komutlar[--_suan] as Komut;
                    komut.Calistirma();
                }
            }
        }
        public void Hesapla(char @operator,int operand){
            Komut komut = new HesaplaKomutu(
                _hesapmakinesi,@operator,operand
            );
            komut.Calistir();
            _komutlar.Add(komut);
            _suan++;
        }

    }
    
}