using System;
using System.Collections.Generic;
namespace Builder
{
    class Arac
    {
        private string _aracTipi;
        private Dictionary<string,string> _parcalar = new Dictionary<string, string>();

        public Arac(string aracTipi){
            this._aracTipi = aracTipi;
        }
        public string this[string key]{
            get{return _parcalar[key];}
            set{_parcalar[key] = value;}
        }
        public void Goster(){
            Console.WriteLine("\n----------------------------");
            Console.WriteLine(" Arac tipi: {0}",_aracTipi);
            Console.WriteLine(" Sasi : {0}",_parcalar["sasi"]);
            Console.WriteLine(" Motor : {0}",_parcalar["motor"]);
            Console.WriteLine(" Tekerlek : {0}",_parcalar["tekerlek"]);
            Console.WriteLine(" Kapılar : {0}",_parcalar["kapilar"]);
        }
    }
}