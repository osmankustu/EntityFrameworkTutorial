﻿// <auto-generated />
using System;
using EntityFrameworkCore.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240209151632_lenghtChangeMigration")]
    partial class lenghtChangeMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameworkCore.Data.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("EntityFrameworkCore.Data.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BirthDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar")
                        .HasDefaultValue("-")
                        .HasColumnName("Name");

                    b.Property<string>("SureName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar")
                        .HasColumnName("SureName");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("EntityFrameworkCore.Data.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BirthDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasDefaultValue("-")
                        .HasColumnName("Name");

                    b.Property<string>("SureName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar")
                        .HasColumnName("SureName");

                    b.HasKey("Id");

                    b.ToTable("Teachers", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}