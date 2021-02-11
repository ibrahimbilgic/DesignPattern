using System;
namespace Adapter
{
    class ZenginBilesik:Bilesik
    {
        private KimyasalVeriBankasi _banka;
        public ZenginBilesik(string isim)
        :base(isim)
        {

        }
        public override void Goster()
        {
            _banka = new KimyasalVeriBankasi();
            
            _kaynamaNoktasi = _banka.GetKritikNokta(_kimyasal,"B");
            _erimeNoktasi = _banka.GetKritikNokta(_kimyasal,"M");
            _molekulerAgirlik = _banka.GetMolekulerAgirlik(_kimyasal);
            _molekulerFormul = _banka.GetMolekulerYapi(_kimyasal);

            base.Goster();
            Console.WriteLine(" Formul: {0}",_molekulerFormul);
            Console.WriteLine(" Agirlik: {0}",_molekulerAgirlik);
            Console.WriteLine(" Erime Noktasi: {0}",_erimeNoktasi);
            Console.WriteLine(" Kaynama Noktasi: {0}",_kaynamaNoktasi);
        }
    }
}