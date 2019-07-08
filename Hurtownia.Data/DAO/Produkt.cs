using System.Collections.Generic;

namespace Hurtownia.Data.DAO
{
    public class Produkt
    {
        public int ProduktId { get; set; }
        public string Producent { get; set; }
        public string Model { get; set; }
        public string Nazwa { get; set; }
        public float CenaNetto { get; set; }
        
        public virtual Kategoria Kategoria { get; set; }
        public virtual ICollection<Pozycja> Pozycje { get; set; }
    }
}