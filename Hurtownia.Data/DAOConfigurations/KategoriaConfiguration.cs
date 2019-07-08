using Hurtownia.Data.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurtownia.Data.DAOConfigurations
{
    public class KategoriaConfiguration: IEntityTypeConfiguration<Kategoria>
    {
        public void Configure(EntityTypeBuilder<Kategoria> builder)
        {
            builder.Property(c => c.NazwaKategorii).IsRequired();
            builder.ToTable("Kategorie");
        }
        
    }
}