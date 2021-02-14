namespace Observer
{
    class IBM:Stok
    {
        public IBM(string sembol, double fiyat)
            :base(sembol,fiyat)
        {
        }
    }
    interface IYatirimci{
        void Guncelle(Stok stok);
    }
}