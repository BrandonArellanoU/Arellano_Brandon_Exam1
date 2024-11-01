﻿// <auto-generated />
using System;
using Arellano_Brandon_Exam1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Arellano_Brandon_Exam1.Migrations
{
    [DbContext(typeof(Arellano_Brandon_Exam1Context))]
    [Migration("20241028125427_PrimeaMigrcion")]
    partial class PrimeaMigrcion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Arellano_Brandon_Exam1.Models.ArellanoB", b =>
                {
                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(200)");

                    b.Property<float>("altura")
                        .HasColumnType("real");

                    b.Property<int>("edad")
                        .HasMaxLength(150)
                        .HasColumnType("int");

                    b.Property<bool>("esHombre")
                        .HasColumnType("bit");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.HasKey("nombre");

                    b.HasIndex("Celular");

                    b.ToTable("ArellanoB");
                });

            modelBuilder.Entity("Arellano_Brandon_Exam1.Models.Celular", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<float>("precio")
                        .HasMaxLength(200)
                        .HasColumnType("real");

                    b.Property<int>("year")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Celular");
                });

            modelBuilder.Entity("Arellano_Brandon_Exam1.Models.ArellanoB", b =>
                {
                    b.HasOne("Arellano_Brandon_Exam1.Models.Celular", "celular")
                        .WithMany()
                        .HasForeignKey("Celular");

                    b.Navigation("celular");
                });
#pragma warning restore 612, 618
        }
    }
}
