using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici = new Kullanici();

            kullanici.Hesapla('+',100);
            kullanici.Hesapla('-',50);
            kullanici.Hesapla('*',10);
            kullanici.Hesapla('/',2);

            kullanici.Ac(4);

            kullanici.tekrarla(3);


        }
    }
}
