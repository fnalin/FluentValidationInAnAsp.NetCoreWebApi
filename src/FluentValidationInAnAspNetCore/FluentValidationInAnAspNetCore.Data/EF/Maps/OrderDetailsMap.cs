using FluentValidationInAnAspNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentValidationInAnAspNetCore.Data.EF.Maps
{
    public class OrderDetailsMap : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.ToTable(nameof(OrderDetails));

            builder.HasKey(c => c.Id);

            builder.Property(col => col.Id)
                    .HasColumnName("Id")
                    .HasColumnType("int")
                    .ValueGeneratedOnAdd();

            builder.Property(col => col.CreationDate)
                   .HasColumnName("CreationDate")
                   .HasColumnType("datetime")
                   .IsRequired();

            builder.Property(col => col.LastUpdatedOn)
                   .HasColumnName("LastUpdatedOn")
                   .HasColumnType("datetime")
                   .IsRequired();

            builder.HasOne(col => col.Order)
                   .WithMany(col => col.OrderDetails)
                   .HasForeignKey(fk => fk.OrderId);

            builder.HasOne(col => col.Product)
                   .WithMany(col => col.OrderDetails)
                   .HasForeignKey(fk => fk.ProductId);

            builder.Property(col => col.UnitPrice)
                  .HasColumnName("UnitPrice")
                  .HasColumnType($"money")
                  .IsRequired();

            builder.Property(col => col.Quantity)
                  .HasColumnName("Quantity")
                  .HasColumnType($"smallint")
                  .IsRequired();

        }
    }
}
