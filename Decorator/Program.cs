using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap("İbrahim","Tasarım Örüntüleri",10);
            kitap.Goster();

            Video video = new Video("Spilberg","Jaws",23,92);
            video.Goster();

            Console.WriteLine("\nVideoyu odunc alınabilir yap:");

            OduncAlinabilir videoAl = new OduncAlinabilir(video);
            videoAl.OduncEsya("Musteri #1");
            videoAl.OduncEsya("Musteri #2 ");

            videoAl.Goster();
        }
    }
}
