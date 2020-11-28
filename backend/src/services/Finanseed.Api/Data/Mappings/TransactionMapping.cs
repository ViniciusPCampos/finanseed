using Finanseed.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finanseed.Api.Data.Mappings
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(t => t.Value)
                .IsRequired();

            builder.Property(t => t.Date)
                .IsRequired();
            
            builder.Property(t => t.ParcelIndex)
                .IsRequired();
            
            builder.Property(t => t.EnumTransactionType)
                .IsRequired();

            builder.HasOne(t => t.Category)
                .WithMany(c => c.Transactions)
                .HasForeignKey(t => t.CategoryId);
            
            builder.HasOne(t => t.Parcel)
                .WithMany(c => c.Transactions)
                .HasForeignKey(t => t.ParcelId);
        }
    }
}