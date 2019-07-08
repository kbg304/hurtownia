using System;
using System.Collections.Generic;

namespace Hurtownia.Data.DAO
{
    public class Zamowienie
    {
        public int ZamowienieId { get; set; }
        public DateTime DataZamowieia { get; set; }
        
        public virtual Firma Firma { get; set; }
        public virtual Faktura Faktura { get; set; }
    }
}