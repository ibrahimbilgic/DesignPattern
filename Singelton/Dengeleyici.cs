using System;
using System.Collections.Generic;

using System.Threading;
namespace Singelton
{
    class Dengeleyici
    {
        private static Dengeleyici _ornek;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        private static object syncLock = new object();

        protected Dengeleyici(){
            _servers.Add("1.Server");
            _servers.Add("2.Server");
            _servers.Add("3.Server");
            _servers.Add("4.Server");
            _servers.Add("5.Server");
        }
        public static Dengeleyici GetDengeleyici(){
            if(_ornek == null){
                lock(syncLock){
                    if(_ornek == null){
                        _ornek = new Dengeleyici();
                    }
                }
            }
            return _ornek;
        }
        public string Server{
            get{
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}