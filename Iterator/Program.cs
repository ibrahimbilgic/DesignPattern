using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Koleksiyon koleksiyon = new Koleksiyon();

            koleksiyon[0] = new Item("Item 0");
            koleksiyon[1] = new Item("Item 1");
            koleksiyon[2] = new Item("Item 2");
            koleksiyon[3] = new Item("Item 3");
            koleksiyon[4] = new Item("Item 4");
            koleksiyon[5] = new Item("Item 5");
            koleksiyon[6] = new Item("Item 6");
            koleksiyon[7] = new Item("Item 7");
            koleksiyon[8] = new Item("Item 8");

            Iterator iterator = koleksiyon.IteratorOlustur();
            iterator.Adim = 2;
            Console.WriteLine("Koleksiyon: ");

            for(Item item = iterator.Ilk();
                    !iterator.TamamMi;
                        item=iterator.Sonraki()){
                            Console.WriteLine(item.Isim);
                        }

        }
    }
}
