using System;

using System.Collections.Generic;
namespace Strategy
{
    abstract class SiralamaStratejisi
    {
        public abstract void Siralama(List<string> list); 
    }
    class HizliSiralama:SiralamaStratejisi
    {
        public override void Siralama(List<string> list){
            list.Sort(); //varsayılan hızlı sıralama
            Console.WriteLine("liste hızlı sıralandı");
        }
    }
    class KabukSiralama:SiralamaStratejisi
    {
        public override void Siralama(List<string> list){
            //list.ShellSort(); uygulanmadı
            Console.WriteLine("Kabuk siralama ile siralandi");
        }
    }
    class BirlestirmeliSiralama:SiralamaStratejisi
    {
        public override void Siralama(List<string> list){
            //list.MergeSort(); uygulanmadı
            Console.WriteLine("Birleşmeli siralama ile siralandi.");
        }
    }
    class SiraliListe{
        private List<string> _list = new List<string>();
        private SiralamaStratejisi _siralamastratejisi;

        public void SetSiralamaStratejisi(SiralamaStratejisi siralama){
            this._siralamastratejisi = siralama;
        }
        public void Ekle(string isim){
            _list.Add(isim);
        }
        public void Siralama(){
            _siralamastratejisi.Siralama(_list);
            foreach(string isim in _list){
                Console.WriteLine(" "+isim);
            }
            Console.WriteLine();
        }
    }

}