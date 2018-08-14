using FluentValidationInAnAspNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentValidationInAnAspNetCore.Data.EF.Maps
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));
                

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

            

            builder.Property(col => col.Name)
                  .HasColumnName("Name")
                  .HasColumnType($"varchar(100)")
                  .IsRequired();

            builder.Property(col => col.City)
                  .HasColumnName("City")
                  .HasColumnType($"varchar(100)")
                  .IsRequired();

            builder.HasData(
                    new Customer(1, "Fernando Alonso", "Madrid"),
                    new Customer(2, "José Carlos", "São Paulo"),
                    new Customer(3, "Leonel Messi", "Buenos Aires")
                );
        }
    }
}
