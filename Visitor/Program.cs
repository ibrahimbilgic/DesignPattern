using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisanlar c = new Calisanlar();
            c.Ac(new Memur());
            c.Ac(new Yonetici());
            c.Ac(new Baskan());

            c.Kabul(new IncomeVisitor());
            c.Kabul(new VacationVisitor());
        }
    }
}
