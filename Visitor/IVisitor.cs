using System;

using System.Collections.Generic;
namespace Visitor
{
    interface IVisitor
    {
         void Visit(Oge oge);
    }
    class IncomeVisitor:IVisitor
    {
        public void Visit(Oge oge){
            Calisan calisan = oge as Calisan;

            calisan.Gelir *=1.10;
            Console.WriteLine("{0} -> {1} --> {2:C}",calisan.GetType().Name,calisan.Ad,calisan.Gelir);
        }
    }
    class VacationVisitor:IVisitor
    {
        public void Visit(Oge oge){
            Calisan calisan = oge as Calisan;
            calisan.TatilGunu += 3;
            Console.WriteLine("{0} -> {1} --> {2} gun tatil",calisan.GetType().Name,calisan.Ad,calisan.TatilGunu);
        }
    }
    abstract class Oge{
        public abstract void Kabul(IVisitor visitor);
    }
    class Calisan:Oge{
        private string _isim;
        private double _gelir;
        private int _tatilGunu;

        public Calisan(string isim,double gelir,int tatilGunu){
            this._isim = isim;
            this._gelir = gelir;
            this._tatilGunu = tatilGunu;
        }
        public string Ad{
            get{return _isim;}
            set{_isim = value;}
        }
        public double Gelir{
            get{return _gelir;}
            set{_gelir = value;}
        }
        public int TatilGunu{
            get{return _tatilGunu;}
            set{_tatilGunu = value;}
        }
        public override void Kabul(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
    class Calisanlar
    {
        private List<Calisan> _calisanlar = new List<Calisan>();

        public void Ac(Calisan calisan){
            _calisanlar.Add(calisan);
        }
        public void Cikar(Calisan calisan){
            _calisanlar.Remove(calisan);
        }
        public void Kabul(IVisitor visitor){
            foreach (Calisan c in _calisanlar)
            {
                c.Kabul(visitor);
            }
            Console.WriteLine();
        }
    }
    class Memur:Calisan{
        public Memur():base("İbrahim",25000.0,14){}
    }
    class Yonetici:Calisan{
        public Yonetici():base("Hurrem",35000.0,16){}
    }
    class Baskan:Calisan{
        public Baskan():base("Zehra",45000.0,21){}
    }
}