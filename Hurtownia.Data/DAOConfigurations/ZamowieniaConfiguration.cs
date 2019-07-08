using Hurtownia.Data.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hurtownia.Data.DAOConfigurations
{
    public class ZamowieniaConfiguration: IEntityTypeConfiguration<Zamowienie>
    {
        public void Configure(EntityTypeBuilder<Zamowienie> builder)
        {
            builder.Property(c => c.DataZamowieia).IsRequired();

            builder.ToTable("Zamowienia");
            
        }
        
    }
}