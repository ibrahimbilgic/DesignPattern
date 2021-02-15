using System;

using System.Data;

using System.Data.OleDb;
namespace Template
{
    abstract class VeriErisimNesnesi
    {
        protected string bagliDize;
        protected VeriKumesi veriKumesi;

        public virtual void Baglanti(){
            bagliDize = "provider=Microsoft.JET.OLEDB.4.0; " 
            +"data source=..\\..\\..\\db1.mdb";
        }
        public abstract void Sec();
        public abstract void Surec();
        public virtual void Kesmek(){
            bagliDize ="";
        }
        public void Calistir(){
            Baglanti();
            Sec();
            Surec();
            Kesmek();
        }
    }
    class Kategoriler:VeriErisimNesnesi
    {
        public override void Sec()
        {
            string sq1 = "Kategoriler arasından KategoriAdi sec";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sq1,bagliDize);

            veriKumesi = new VeriKumesi();
            dataAdapter.Fill(veriKumesi,"Kategoriler");
        }
        public override void Surec()
        {
            Console.WriteLine("Kategoriler ----");
            DataTable dataTable = veriKumesi.Tables["Kategoriler"];
            foreach (VeriSatiri satir in dataTable.Satir)
            {
                Console.WriteLine(satir["KategoriAdi"]);
            }
            Console.WriteLine();
        }
    }
    class Urunler:VeriErisimNesnesi
    {
        public override void Sec()
        {
            string sq1 = "Urunler arasından UrunAdi sec";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sq1,bagliDize);

            veriKumesi = new VeriKumesi();
            dataAdapter.Fill(veriKumesi,"Urunler");
        }
        public override void Surec()
        {
            Console.WriteLine("Urunler -----");
            DataTable dataTable = veriKumesi.Tables["Urunler"];
            foreach (VeriSatiri satir in dataTable.Satir)
            {
                Console.WriteLine(satir["UrunAdi"]);
            }
            Console.WriteLine();
        }
    }
}