﻿// <auto-generated />
using System;
using CarInventoryREST.DbModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarInventoryREST.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarInventoryREST.Models.Entities.Cars", b =>
                {
                    b.Property<Guid>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
