using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            MathProxy proxy = new MathProxy();
            Console.WriteLine("18 + 81 = "+proxy.Topla(18,81));
            Console.WriteLine("18 - 81 = "+proxy.Cikar(18,81));
            Console.WriteLine("18 * 81 = "+proxy.Carp(18,81));
            Console.WriteLine("18 / 81 = "+proxy.Bol(18,81));
        }
    }
}
