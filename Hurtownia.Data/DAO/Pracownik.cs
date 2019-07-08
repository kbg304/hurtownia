

using System.Collections.Generic;

namespace Hurtownia.Data.DAO
{
    public class Pracownik
    {
        public int PracownikId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }
        public float PensjaBrutto { get; set; }
        
        public virtual Adres Adres { get; set; }
        public virtual ICollection<Faktura> Faktury { get; set; }
    }
}