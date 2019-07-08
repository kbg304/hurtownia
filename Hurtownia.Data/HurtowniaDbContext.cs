using Microsoft.EntityFrameworkCore;
using Hurtownia.Data.DAO;
using Hurtownia.Data.DAOConfigurations;

namespace Hurtownia.Data
{
    public class HurtowniaDbContext: DbContext
    {
        public HurtowniaDbContext(DbContextOptions<HurtowniaDbContext> options): base(options){}
        
        
        public virtual DbSet<Adres> Adresy { get; set; }
        public virtual DbSet<Klient> Klienci { get; set; }
        public virtual DbSet<Pracownik> Pracownicy { get; set; }
        public virtual DbSet<Firma> Firmy { get; set; }
        public virtual DbSet<Zamowienie> Zamowienia { get; set; }
        public virtual DbSet<Faktura> Faktury { get; set; }
        public virtual DbSet<Pozycja> Pozycje { get; set; }
        public virtual DbSet<Produkt> Produkty { get; set; }
        public virtual DbSet<Kategoria> Kategorie { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AdresConfiguration());   
            builder.ApplyConfiguration(new KategoriaConfiguration());
            builder.ApplyConfiguration(new KlientConfiguration());
            builder.ApplyConfiguration(new PracownikConfiguration());
            builder.ApplyConfiguration(new FirmaConfiguration());
            builder.ApplyConfiguration(new ZamowieniaConfiguration());
            builder.ApplyConfiguration(new FakturaConfiguration());
            builder.ApplyConfiguration(new PozycjeConfiguration());
            builder.ApplyConfiguration(new ProduktConfiguration());

        }
        
        
    }
    
    
}