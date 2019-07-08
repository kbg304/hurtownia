using Hurtownia.Data.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurtownia.Data.DAOConfigurations
{
    public class FakturaConfiguration: IEntityTypeConfiguration<Faktura>
    {
        public void Configure(EntityTypeBuilder<Faktura> builder)
        {
            builder.Property(c => c.NumerFaktury).HasMaxLength(10).IsRequired();
            builder.Property(c => c.Vat).IsRequired();
            builder.Property(c => c.SposobPlatonosci).HasMaxLength(10).IsRequired();
            builder.Property(c => c.DataWystawienia).IsRequired();
            builder.Property(c => c.TerminPlatnosci).IsRequired();
            builder.ToTable("Faktury");
        }
        
    }
}