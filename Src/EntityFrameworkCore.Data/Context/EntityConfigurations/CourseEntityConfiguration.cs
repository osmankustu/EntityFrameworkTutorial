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
    public class CourseEntityConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> entity)
        {
            //Tablo Adını Set Eder default schema ismini de alır
            entity.ToTable("Courses");

            entity.Property(i => i.Id)
                  //sütun adı 
                  .HasColumnName("Id")
                  //sütun veri tipi 
                  .HasColumnType("int")
                  //PK set edilmesi
                  .UseIdentityColumn(1)
                  //Gerekli Alan 
                  .IsRequired();

            entity.Property(i => i.Name)
                  .HasColumnName("Name")
                  .HasColumnType("nvarchar")
                  //maximum karakter uzunluğu
                  .HasMaxLength(100);

            entity.Property(i => i.IsActive)
                .HasColumnName("IsActive");

        }
    }
}
