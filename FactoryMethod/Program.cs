using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Belge[] belgeler = new Belge[2];
            belgeler[0] = new OzGecmis();
            belgeler[1] = new Raporla();

            foreach(Belge belge in belgeler){
                Console.WriteLine("\n " + belge.GetType().Name + "--");
                foreach(Sayfa sayfa in belge.Sayfalar){
                    Console.WriteLine(" "+sayfa.GetType().Name);
                }
            }
        }
    }
}
