using System;
namespace AbstractFactory
{
    class Kurt:Etcil
    {
        public override void Yer(Otcul o)
        {
            Console.WriteLine(this.GetType().Name+ " yer "+o.GetType().Name);
        }   
    }
}