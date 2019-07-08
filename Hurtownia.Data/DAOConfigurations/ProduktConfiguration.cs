using Hurtownia.Data.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurtownia.Data.DAOConfigurations
{
    public class ProduktConfiguration: IEntityTypeConfiguration<Produkt>
    {
        public void Configure(EntityTypeBuilder<Produkt> builder)
        {
            builder.Property(c => c.Producent).IsRequired();
            builder.Property(c => c.Model).IsRequired();
            builder.Property(c => c.Nazwa).IsRequired();
            builder.Property(c => c.CenaNetto).IsRequired();
            builder.ToTable("Produkty");
        }
        
    }
}