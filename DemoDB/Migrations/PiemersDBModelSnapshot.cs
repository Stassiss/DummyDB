﻿// <auto-generated />
using DemoDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoDB.Migrations
{
    [DbContext(typeof(PiemersDB))]
    partial class PiemersDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoDB.Models.Piemers", b =>
                {
                    b.Property<int>("CodeName")
                        .HasColumnName("Trasakcijas_kods")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnName("Apraksts")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Piemers");
                });
#pragma warning restore 612, 618
        }
    }
}