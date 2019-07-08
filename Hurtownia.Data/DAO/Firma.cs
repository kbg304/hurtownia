using System.Collections.Generic;

namespace Hurtownia.Data.DAO
{
    public class Firma
    {
        public int FirmaId { get; set; }
        public string Nazwa { get; set; }
        public string Nip { get; set; }
        public string Regon { get; set; }
        
        public virtual Adres Adres { get; set; }
        public virtual Klient Klient { get; set; }
        public virtual ICollection<Zamowienie> Zamowienia { get; set; }
    }
}