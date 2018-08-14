using FluentValidationInAnAspNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentValidationInAnAspNetCore.Data.EF.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));
                

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

            builder.Property(col => col.Details)
                  .HasColumnName("Details")
                  .HasColumnType($"varchar(300)");

            builder.Property(col => col.UnitsInStock)
                  .HasColumnName("UnitsInStock")
                  .HasColumnType($"int")
                  .IsRequired();

            builder.Property(col => col.UnitPrice)
                  .HasColumnName("UnitPrice")
                  .HasColumnType($"money")
                  .IsRequired();

            builder.HasData(
                    new Product(1, "Pasta de Dente", "Pasta de Dente Colgate", 1520, 9.99M),
                    new Product(2, "Shampoo Neutro", "Shampoo para carecas", 220, 15.59M),
                    new Product(3, "Astes p/ Ouvido", "Vulgo Cotonete", 2511, 20.99M),
                    new Product(4, "Fralda Pampers", "Para o cagão do seu filho", 520, 120.99M),
                    new Product(5, "Danone", "Danoninho", 299, 15.99M)
                );

        }
    }
}
