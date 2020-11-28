using Finanseed.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finanseed.Api.Data.Mappings
{
    public class ParcelMapping : IEntityTypeConfiguration<Parcel>
    {
        public void Configure(EntityTypeBuilder<Parcel> builder)
        {
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Description)
                .IsRequired()
                .HasColumnType("varchar(250)");
            
            builder.Property(p => p.Number)
                .IsRequired();
            
        }
    }
}