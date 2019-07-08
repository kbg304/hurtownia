using System.Collections.Generic;

namespace Hurtownia.Data.DAO
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public string NazwaKategorii { get; set; }
        
        public virtual ICollection<Produkt> Produkty { get; set; }
    }
}