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
    public class StudentEntitiyConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> entity)
        {
            //Table and Schema Name configuring
            entity.ToTable("Students");

            // object properties access function
            entity.Property(i => i.Id)
                  //column name setting
                  .HasColumnName("Id")
                  //colmun data type setting
                  .HasColumnType("int")
                  //primary key setting 
                  .UseIdentityColumn(1)
                  //required field setting
                  .IsRequired();

            entity.Property(i => i.Name)
                  .HasColumnName("Name")
                  .HasColumnType("nvarchar")
                  // max character lenght
                  .HasMaxLength(250)
                  // if data is null set default "-" else data is parameter
                  .HasDefaultValue("-");

            entity.Property(i => i.SureName)
                .HasColumnName("SureName")
                .HasColumnType("nvarchar")
                .HasMaxLength(250);

            entity.Property(i => i.BirthDate)
                .HasColumnName("BirthDate");

            entity.Property(i => i.AddressId)
                .HasColumnName("AddressId");

            //one to one relationship configuring with HasOne , WithOne
            //many to many relationship configuring with HasMany ,WithMany
            //one to many relationship configuring with HasOne ,WithMany

            entity.HasMany(i => i.Books)
                .WithOne(i => i.Student)
                .HasForeignKey(i => i.StudentId)
                .HasConstraintName("student_book_id_fk");
        }
    }
}
