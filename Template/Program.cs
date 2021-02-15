using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            VeriErisimNesnesi daoKategoriler = new Kategoriler();
            daoKategoriler.Calistir();

            VeriErisimNesnesi doaUrunler = new Urunler();
            doaUrunler.Calistir();
        }
    }
}
