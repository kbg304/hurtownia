using System;
using System.Collections.Generic;

namespace Hurtownia.Data.DAO
{
    public class Faktura
    {
        public int FakturaId { get; set; }
        public string NumerFaktury { get; set; }
        public int Vat { get; set; }
        public string SposobPlatonosci { get; set; }
        public DateTime DataWystawienia { get; set; }
        public DateTime TerminPlatnosci { get; set; }
        
        public virtual ICollection<Zamowienie> Zamowienia { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual ICollection<Pozycja> Pozycje { get; set; }
    }
}