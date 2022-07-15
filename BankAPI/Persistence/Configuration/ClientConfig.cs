using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Name)
                .HasMaxLength(80)
                .IsRequired();
            builder.Property(c => c.LastName)
                .HasMaxLength(80)
                .IsRequired();
            builder.Property(c => c.BirthDate)
                .IsRequired();
            builder.Property(c => c.Phone)
                .HasMaxLength(9)
                .IsRequired();
            builder.Property(c => c.Email)
                .HasMaxLength(100);
            builder.Property(c => c.Address)
                .HasMaxLength(120)
                .IsRequired();
            builder.Property(c => c.Age);

            builder.Property(c => c.CreatedBy)
                .HasMaxLength(50);
            builder.Property(c => c.LastModifiedBy)
               .HasMaxLength(50);

        }
    }
}
