using Hurtownia.Data.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.BouncyCastle.Crypto.Tls;

namespace Hurtownia.Data.DAOConfigurations
{
    public class KlientConfiguration: IEntityTypeConfiguration<Klient>
    {
        public void Configure(EntityTypeBuilder<Klient> builder)
        {
            builder.Property(c => c.Imie).IsRequired();
            builder.Property(c => c.Nazwisko).IsRequired();
            builder.ToTable("Klienci");
        }
    }
}