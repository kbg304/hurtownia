namespace Hurtownia.Data.DAO
{
    public class Pozycja
    {
        public int PozycjaId { get; set; }
        public float Rabat { get; set; }
        public int Ilosc { get; set; }
        
        public virtual Faktura Faktura { get; set; }
        public virtual Produkt Produkt { get; set; }

    }
}