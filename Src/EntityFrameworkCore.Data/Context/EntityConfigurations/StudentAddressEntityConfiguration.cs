using EntityFrameworkCore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data.Context.EntityConfigurations
{
    public class StudentAddressEntityConfiguration : IEntityTypeConfiguration<StudentAddress>
    {
        public void Configure(EntityTypeBuilder<StudentAddress> entity)
        {
            entity.ToTable("StudentAddress");

            entity.Property(i => i.Id)
                .HasColumnName("id")
                .UseIdentityColumn();

            entity.Property(i => i.City)
                .HasColumnName("Ctiy")
                .HasColumnType("nvarchar");

            entity.Property(i => i.Country)
                .HasColumnName("Country")
                .HasColumnType("nvarchar");

            entity.Property(i => i.FullAddress)
                .HasColumnName("FullAddress")
                .HasMaxLength(1000);

            entity.Property(i => i.Distric)
                .HasColumnName("Distric")
                .HasColumnType("navrchar")
                .HasMaxLength(100);

         

            // for a one-to-one relationship
            // Association between the address
            // attribute of the student table
            // in the database and the student ID in the student address table

            //one to one relationship configuring with HasOne , WithOne
            //many to many relationship configuring with HasMany ,WithMany
            //one to many relationship configuring with HasOne ,WithMany

            entity.HasOne(i => i.Student)
                .WithOne(i => i.Address)
                .HasForeignKey<Student>(i => i.AddressId)
                .HasConstraintName("StudentAddress_Student_id_fk");


        }
    }
}
