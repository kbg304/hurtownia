using Hurtownia.Data.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurtownia.Data.DAOConfigurations
{
    public class FirmaConfiguration: IEntityTypeConfiguration<Firma>
    {
        public void Configure(EntityTypeBuilder<Firma> builder)
        {
            builder.Property(c => c.Nazwa).IsRequired();
            builder.Property(c => c.Nip).HasMaxLength(10).IsRequired();
            builder.Property(c => c.Regon).HasMaxLength(14).IsRequired();

            builder.ToTable("Firmy");

        }
        
    }
}