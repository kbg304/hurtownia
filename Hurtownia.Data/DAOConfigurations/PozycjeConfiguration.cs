using Hurtownia.Data.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurtownia.Data.DAOConfigurations
{
    public class PozycjeConfiguration: IEntityTypeConfiguration<Pozycja>
    {
        public void Configure(EntityTypeBuilder<Pozycja> builder)
        {
            builder.Property(c => c.Ilosc).IsRequired();

            builder.ToTable("Pozycje");
        }
        
    }
}