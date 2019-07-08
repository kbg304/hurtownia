using Hurtownia.Data.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurtownia.Data.DAOConfigurations
{
    public class PracownikConfiguration: IEntityTypeConfiguration<Pracownik>
    {
        public void Configure(EntityTypeBuilder<Pracownik> builder)
        {
            builder.Property(c => c.Imie).IsRequired();
            builder.Property(c => c.Nazwisko).IsRequired();
            builder.Property(c => c.Stanowisko).IsRequired();
            builder.Property(c => c.PensjaBrutto).IsRequired();

            builder.ToTable("Pracownicy");
        }
        
    }
}