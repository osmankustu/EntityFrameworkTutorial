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
    public class TeacherEntityConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> entity)
        {
            //Tablo Adını Set Eder default schema ismini de alır
            entity.ToTable("Teachers");

            // varlık özelliklerine erişmek için fonksiyon
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
                  .HasMaxLength(100)
                  //boş gelirse default değeri 
                  .HasDefaultValue("-");

            entity.Property(i => i.SureName)
                .HasColumnName("SureName")
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            entity.Property(i => i.BirthDate)
                .HasColumnName("BirthDate");

        }
    }
}
