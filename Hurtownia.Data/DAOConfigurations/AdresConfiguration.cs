using Hurtownia.Data.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurtownia.Data.DAOConfigurations
{
    public class AdresConfiguration: IEntityTypeConfiguration<Adres>
    {
        public void Configure(EntityTypeBuilder<Adres> builder)
        {
            builder.Property(c => c.Miejscowosc).IsRequired();
            builder.Property(c => c.NrDomu).HasMaxLength(5).IsRequired();
            builder.Property(c => c.KodPocztowy).HasMaxLength(6).IsRequired();
            builder.ToTable("Adresy");

        }
        
    }
}