using System;
using System.Collections;
namespace Iterator
{
    class Item
    {
        public string _isim;
        public Item(string isim){
            this._isim=isim;
        }        
        public string Isim{
            get{return _isim;}
        }
    }
    interface ISoyutKoleksiyon{
        Iterator IteratorOlustur();
    }
    class Koleksiyon:ISoyutKoleksiyon{
        private ArrayList _itemler = new ArrayList();
        public Iterator IteratorOlustur(){
            return new Iterator(this);
        }
        public int Count{
            get{return _itemler.Count;}
        }
        public object this[int index]{
            get{return _itemler[index];}
            set{_itemler.Add(value);}
        }
    }
    interface ISoyutIterator{
        Item Ilk();
        Item Sonraki();
        bool TamamMi {get;}
        Item SuankiItem {get;}
    }
    class Iterator:ISoyutIterator{
        private Koleksiyon _koleksiyon;
        private int _suanki = 0;
        private int _adim = 1;      

        public Iterator(Koleksiyon koleksiyon){
            this._koleksiyon = koleksiyon;
        }  
        public Item Ilk(){
            _suanki = 0;
            return _koleksiyon[_suanki] as Item;
        }
        public Item Sonraki(){
            _suanki += _adim;
            if(!TamamMi){
                return _koleksiyon[_suanki] as Item;
            }
            else{
                return null;
            }
        }
        public int Adim{
            get{return _adim;}
            set{_adim = value;}
        }
        public Item SuankiItem{
            get{return _koleksiyon[_suanki] as Item;}
        }
        public bool TamamMi{
            get{return _suanki >= _koleksiyon.Count;}
        }
    }
}