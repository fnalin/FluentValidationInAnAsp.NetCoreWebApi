using FluentValidationInAnAspNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentValidationInAnAspNetCore.Data.EF.Maps
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(nameof(Order));

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

            builder.HasOne(col => col.Customer)
                    .WithMany(col => col.Orders)
                    .HasForeignKey(fk => fk.CustomerId);

            builder.HasOne(col => col.Employee)
                    .WithMany(col => col.Orders)
                    .HasForeignKey(fk => fk.EmployeeId);
        }
    }
}
