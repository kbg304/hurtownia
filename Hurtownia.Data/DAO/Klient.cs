using System.Collections.Generic;

namespace Hurtownia.Data.DAO
{
    public class Klient
    {
        public int KlientId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NrTel { get; set; }
        public string Email { get; set; }
        

        public virtual Adres Adres { get; set; }
        public virtual ICollection<Firma> Firmy { get; set; }
        
    }
}