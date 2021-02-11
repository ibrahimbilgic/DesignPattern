using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilesik bilinmeyen = new Bilesik("Bilinmeyen");
            bilinmeyen.Goster();

            Bilesik su =new ZenginBilesik("su");
            su.Goster();

            Bilesik benzen = new ZenginBilesik("benzen");
            benzen.Goster();

            Bilesik ethanol = new ZenginBilesik("ethanol");
            ethanol.Goster();
        }
    }
}
