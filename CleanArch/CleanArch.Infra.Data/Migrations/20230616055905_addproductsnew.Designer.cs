﻿// <auto-generated />
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanArch.Infra.Data.Migrations
{
    [DbContext(typeof(UniversityDBContext))]
    [Migration("20230616055905_addproductsnew")]
    partial class addproductsnew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CleanArch.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Low Lights"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Average Light"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Strong Light"
                        });
                });

            modelBuilder.Entity("CleanArch.Domain.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CleanArch.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "H&M",
                            Code = 94,
                            Color = "White/Black striped",
                            Description = "\r\nShort-sleeved shirt in a linen and cotton weave with a resort collar, French front and open chest pocket. Yoke with darts at the back, and a straight-cut hem. Regular Fit – a classic fit with good room for movement and a gently tapered waist to create a comfortable, tailored silhouette. ",
                            Price = 240.0,
                            Title = "Regular Fit Resort shirt"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "zara",
                            Code = 393,
                            Color = "white",
                            Description = "\r\nAnkle-length jeans in washed cotton denim with fake front pockets, real back pockets and straight legs. Wide jersey panel at the waist for best fit over the tummy. ",
                            Price = 625.0,
                            Title = "MAMA Straight Ankle Jeans"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Concret",
                            Code = 1630,
                            Color = "Khaki green",
                            Description = "\r\nSingle-breasted jacket in a stretch weave with narrow notch lapels with a decorative buttonhole, a chest pocket, flap front pockets and one inner pocket. Two buttons at the front, decorative buttons at the cuffs and a single back vent. Lined. Slim fit that tapers at the chest and waist which, combined with slightly narrower sleeves, creates a fitted silhouette. ",
                            Price = 2100.0,
                            Title = "Jacket Slim Fit"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "zara",
                            Code = 10,
                            Color = "Beige",
                            Description = "\r\nT-shirt in soft cotton jersey with sleeves in contrasting colours. Relaxed fit with a round, rib-trimmed neckline, dropped shoulders, an open chest pocket and a straight-cut hem. ",
                            Price = 170.0,
                            Title = "Relaxed Fit Pocket-detail T-shirt"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "polo",
                            Code = 120,
                            Color = "red",
                            Description = "\r\nT-shirt in soft cotton jersey with sleeves in contrasting colours. Relaxed fit with a round, rib-trimmed neckline, dropped shoulders, an open chest pocket and a straight-cut hem. ",
                            Price = 1270.0,
                            Title = "T-shirt"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "zara",
                            Code = 410,
                            Color = "white",
                            Description = "\r\nT-shirt in soft cotton jersey with sleeves in contrasting colours. Relaxed fit with a round, rib-trimmed neckline, dropped shoulders, an open chest pocket and a straight-cut hem. ",
                            Price = 470.0,
                            Title = "jeans"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
