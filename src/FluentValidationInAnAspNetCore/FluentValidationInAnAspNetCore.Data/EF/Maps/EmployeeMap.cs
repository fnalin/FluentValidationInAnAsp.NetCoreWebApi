using FluentValidationInAnAspNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FluentValidationInAnAspNetCore.Data.EF.Maps
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable(nameof(Employee));
                

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

            builder.Property(col => col.BirthDate)
                   .HasColumnName("BirthDate")
                   .HasColumnType("date")
                   .IsRequired();

            builder.HasData(
                    new Employee(1, "Fabiano Nalin", new DateTime(1979, 9, 12)),
                    new Employee(2, "Raphael Nalin", new DateTime(1999, 8, 20)),
                    new Employee(3, "Priscila Mitui", new DateTime(1978, 6, 9))
                );
        }
    }
}
