﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Data;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230712123952_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Server.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePicture")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("Server.Data.Models.ApplicationUserProperty", b =>
                {
                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ApplicationUserId", "PropertyId");

                    b.HasIndex("PropertyId");

                    b.ToTable("ApplicationUserProperties");
                });

            modelBuilder.Entity("Server.Data.Models.City", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Sofia"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Plovdiv"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Varna"
                        },
                        new
                        {
                            Id = "4",
                            Name = "Burgas"
                        },
                        new
                        {
                            Id = "5",
                            Name = "Stara Zagora"
                        },
                        new
                        {
                            Id = "6",
                            Name = "Nesebar"
                        },
                        new
                        {
                            Id = "7",
                            Name = "Bansko"
                        },
                        new
                        {
                            Id = "8",
                            Name = "Veliko Tarnovo"
                        },
                        new
                        {
                            Id = "9",
                            Name = "Smolyan"
                        },
                        new
                        {
                            Id = "10",
                            Name = "Blagoevgrad"
                        },
                        new
                        {
                            Id = "11",
                            Name = "Ruse"
                        },
                        new
                        {
                            Id = "12",
                            Name = "Vratza"
                        },
                        new
                        {
                            Id = "13",
                            Name = "Kuklen"
                        },
                        new
                        {
                            Id = "14",
                            Name = "Asenovgrad"
                        },
                        new
                        {
                            Id = "15",
                            Name = "Velingrad"
                        },
                        new
                        {
                            Id = "16",
                            Name = "Koprivshtitza"
                        },
                        new
                        {
                            Id = "17",
                            Name = "Gabrovo"
                        },
                        new
                        {
                            Id = "18",
                            Name = "Sozopol"
                        });
                });

            modelBuilder.Entity("Server.Data.Models.Post", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Server.Data.Models.Property", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PropertyTypeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("SquareMeters")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PropertyTypeId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Server.Data.Models.PropertyType", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Title = "House"
                        },
                        new
                        {
                            Id = "2",
                            Title = "Apartment"
                        },
                        new
                        {
                            Id = "3",
                            Title = "Villa"
                        },
                        new
                        {
                            Id = "4",
                            Title = "Office"
                        },
                        new
                        {
                            Id = "5",
                            Title = "Shop"
                        },
                        new
                        {
                            Id = "6",
                            Title = "Hotel"
                        });
                });

            modelBuilder.Entity("Server.Data.Models.ApplicationUserProperty", b =>
                {
                    b.HasOne("Server.Data.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("ApplicationUserProperties")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Server.Data.Models.Property", "Property")
                        .WithMany("ApplicationUserProperties")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Server.Data.Models.Post", b =>
                {
                    b.HasOne("Server.Data.Models.ApplicationUser", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Server.Data.Models.Property", "Property")
                        .WithMany("Posts")
                        .HasForeignKey("PropertyId");

                    b.Navigation("Author");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Server.Data.Models.Property", b =>
                {
                    b.HasOne("Server.Data.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Server.Data.Models.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Server.Data.Models.PropertyType", "PropertyType")
                        .WithMany("Properties")
                        .HasForeignKey("PropertyTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Owner");

                    b.Navigation("PropertyType");
                });

            modelBuilder.Entity("Server.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("ApplicationUserProperties");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Server.Data.Models.Property", b =>
                {
                    b.Navigation("ApplicationUserProperties");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Server.Data.Models.PropertyType", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
