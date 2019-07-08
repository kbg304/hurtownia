using System.Collections.Generic;

namespace Hurtownia.Data.DAO
{
    public class Adres
    {
        public int AdresId { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string NrLokalu { get; set; }
        public string KodPocztowy { get; set; }
        
        public virtual ICollection<Klient> Klienci { get; set; }
        public virtual ICollection<Pracownik> Pracownicy { get; set; }
        public virtual ICollection<Firma> Firmy { get; set; }
        
        
        
    }
}