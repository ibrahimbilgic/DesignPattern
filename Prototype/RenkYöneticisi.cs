using System.Collections.Generic;
namespace Prototype
{
    class RenkYöneticisi
    {
        private Dictionary<string,RenkPrototipi> _renkler =
        new Dictionary<string, RenkPrototipi>();

        public RenkPrototipi this[string anahtar]{
            get{return _renkler[anahtar];}
            set{_renkler.Add(anahtar,value);}
        }
    }
}