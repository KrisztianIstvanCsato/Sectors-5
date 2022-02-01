﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sectors.Server.Data;

#nullable disable

namespace Sectors.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Sectors.Shared.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SectorsDb");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manufacturing",
                            SectorId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Construction materials",
                            SectorId = 19
                        },
                        new
                        {
                            Id = 3,
                            Name = "Electronics and Optics",
                            SectorId = 18
                        },
                        new
                        {
                            Id = 4,
                            Name = "Food and Beverage",
                            SectorId = 6
                        },
                        new
                        {
                            Id = 5,
                            Name = "Bakery & confectionery products",
                            SectorId = 342
                        },
                        new
                        {
                            Id = 6,
                            Name = "Beverages",
                            SectorId = 43
                        },
                        new
                        {
                            Id = 7,
                            Name = "Fish & fish products",
                            SectorId = 42
                        },
                        new
                        {
                            Id = 8,
                            Name = "Meat & meat products",
                            SectorId = 40
                        },
                        new
                        {
                            Id = 9,
                            Name = "Milk & dairy products",
                            SectorId = 39
                        },
                        new
                        {
                            Id = 10,
                            Name = "Other",
                            SectorId = 437
                        },
                        new
                        {
                            Id = 11,
                            Name = "Sweets & snack food",
                            SectorId = 378
                        },
                        new
                        {
                            Id = 12,
                            Name = "Furniture",
                            SectorId = 13
                        },
                        new
                        {
                            Id = 13,
                            Name = "Bathroom/sauna",
                            SectorId = 389
                        },
                        new
                        {
                            Id = 14,
                            Name = "Bedroom",
                            SectorId = 385
                        },
                        new
                        {
                            Id = 15,
                            Name = "Children’s room",
                            SectorId = 390
                        },
                        new
                        {
                            Id = 16,
                            Name = "Kitchen",
                            SectorId = 98
                        },
                        new
                        {
                            Id = 17,
                            Name = "Living room",
                            SectorId = 101
                        },
                        new
                        {
                            Id = 18,
                            Name = "Office",
                            SectorId = 392
                        },
                        new
                        {
                            Id = 19,
                            Name = "Other (Furniture)",
                            SectorId = 394
                        },
                        new
                        {
                            Id = 20,
                            Name = "Outdoor",
                            SectorId = 341
                        },
                        new
                        {
                            Id = 21,
                            Name = "Project furniture",
                            SectorId = 99
                        },
                        new
                        {
                            Id = 22,
                            Name = "Machinery",
                            SectorId = 12
                        },
                        new
                        {
                            Id = 23,
                            Name = "Machinery components",
                            SectorId = 94
                        },
                        new
                        {
                            Id = 24,
                            Name = "Machinery equipment/tools",
                            SectorId = 91
                        },
                        new
                        {
                            Id = 25,
                            Name = "Manufacture of machinery",
                            SectorId = 224
                        },
                        new
                        {
                            Id = 26,
                            Name = "Maritime",
                            SectorId = 97
                        },
                        new
                        {
                            Id = 27,
                            Name = "Aluminium and steel workboats",
                            SectorId = 271
                        },
                        new
                        {
                            Id = 28,
                            Name = "Boat/Yacht building",
                            SectorId = 269
                        },
                        new
                        {
                            Id = 29,
                            Name = "Ship repair and conversion",
                            SectorId = 230
                        },
                        new
                        {
                            Id = 30,
                            Name = "Metal structures",
                            SectorId = 93
                        },
                        new
                        {
                            Id = 31,
                            Name = "Other",
                            SectorId = 508
                        },
                        new
                        {
                            Id = 32,
                            Name = "Repair and maintenance service",
                            SectorId = 227
                        },
                        new
                        {
                            Id = 33,
                            Name = "Metalworking",
                            SectorId = 11
                        },
                        new
                        {
                            Id = 34,
                            Name = "Construction of metal structures",
                            SectorId = 67
                        },
                        new
                        {
                            Id = 35,
                            Name = "Houses and buildings",
                            SectorId = 263
                        },
                        new
                        {
                            Id = 36,
                            Name = "Metal products",
                            SectorId = 267
                        },
                        new
                        {
                            Id = 37,
                            Name = "Metal works",
                            SectorId = 542
                        },
                        new
                        {
                            Id = 38,
                            Name = "CNC-machining",
                            SectorId = 75
                        },
                        new
                        {
                            Id = 39,
                            Name = "Forgings, Fasteners",
                            SectorId = 62
                        },
                        new
                        {
                            Id = 40,
                            Name = "Gas, Plasma, Laser cutting",
                            SectorId = 69
                        },
                        new
                        {
                            Id = 41,
                            Name = "MIG, TIG, Aluminum welding",
                            SectorId = 66
                        },
                        new
                        {
                            Id = 42,
                            Name = "Plastic and Rubber",
                            SectorId = 9
                        },
                        new
                        {
                            Id = 43,
                            Name = "Packaging",
                            SectorId = 54
                        },
                        new
                        {
                            Id = 44,
                            Name = "Plastic goods",
                            SectorId = 556
                        },
                        new
                        {
                            Id = 45,
                            Name = "Plastic processing technology",
                            SectorId = 559
                        },
                        new
                        {
                            Id = 46,
                            Name = "Blowing",
                            SectorId = 55
                        },
                        new
                        {
                            Id = 47,
                            Name = "Moulding",
                            SectorId = 57
                        },
                        new
                        {
                            Id = 48,
                            Name = "Plastics welding and processing",
                            SectorId = 53
                        },
                        new
                        {
                            Id = 49,
                            Name = "Plastic profiles",
                            SectorId = 560
                        },
                        new
                        {
                            Id = 50,
                            Name = "Printing",
                            SectorId = 5
                        },
                        new
                        {
                            Id = 51,
                            Name = "Advertising",
                            SectorId = 148
                        },
                        new
                        {
                            Id = 52,
                            Name = "Book/Periodicals printing",
                            SectorId = 150
                        },
                        new
                        {
                            Id = 53,
                            Name = "Labelling and packaging printing",
                            SectorId = 145
                        },
                        new
                        {
                            Id = 54,
                            Name = "Textile and Clothing",
                            SectorId = 7
                        },
                        new
                        {
                            Id = 55,
                            Name = "Clothing",
                            SectorId = 44
                        },
                        new
                        {
                            Id = 56,
                            Name = "Textile",
                            SectorId = 45
                        },
                        new
                        {
                            Id = 57,
                            Name = "Wood",
                            SectorId = 8
                        },
                        new
                        {
                            Id = 58,
                            Name = "Other (Wood)",
                            SectorId = 337
                        },
                        new
                        {
                            Id = 59,
                            Name = "Wooden building materials",
                            SectorId = 51
                        },
                        new
                        {
                            Id = 60,
                            Name = "Wooden houses",
                            SectorId = 47
                        },
                        new
                        {
                            Id = 61,
                            Name = "Other",
                            SectorId = 3
                        },
                        new
                        {
                            Id = 62,
                            Name = "Creative industries",
                            SectorId = 37
                        },
                        new
                        {
                            Id = 63,
                            Name = "Energy technology",
                            SectorId = 29
                        },
                        new
                        {
                            Id = 64,
                            Name = "Environment",
                            SectorId = 33
                        },
                        new
                        {
                            Id = 65,
                            Name = "Service",
                            SectorId = 2
                        },
                        new
                        {
                            Id = 66,
                            Name = "Business services",
                            SectorId = 25
                        },
                        new
                        {
                            Id = 67,
                            Name = "Engineering",
                            SectorId = 35
                        },
                        new
                        {
                            Id = 68,
                            Name = "Information Technology and Telecommunications",
                            SectorId = 28
                        },
                        new
                        {
                            Id = 69,
                            Name = "Data processing, Web portals, E-marketing",
                            SectorId = 581
                        },
                        new
                        {
                            Id = 70,
                            Name = "Programming, Consultancy",
                            SectorId = 576
                        },
                        new
                        {
                            Id = 71,
                            Name = "Software, Hardware",
                            SectorId = 121
                        },
                        new
                        {
                            Id = 72,
                            Name = "Telecommunications",
                            SectorId = 122
                        },
                        new
                        {
                            Id = 73,
                            Name = "Tourism",
                            SectorId = 22
                        },
                        new
                        {
                            Id = 74,
                            Name = "Translation services",
                            SectorId = 141
                        },
                        new
                        {
                            Id = 75,
                            Name = "Transport and Logistics",
                            SectorId = 21
                        },
                        new
                        {
                            Id = 76,
                            Name = "Air",
                            SectorId = 111
                        },
                        new
                        {
                            Id = 77,
                            Name = "Rail",
                            SectorId = 114
                        },
                        new
                        {
                            Id = 78,
                            Name = "Road",
                            SectorId = 112
                        },
                        new
                        {
                            Id = 79,
                            Name = "Water",
                            SectorId = 113
                        });
                });

            modelBuilder.Entity("Sectors.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Agreed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UsersDb");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Agreed = true,
                            Name = "TestPerson"
                        });
                });

            modelBuilder.Entity("Sectors.Shared.User_Sector", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "SectorId");

                    b.HasIndex("SectorId");

                    b.ToTable("User_Sectors");
                });

            modelBuilder.Entity("Sectors.Shared.User_Sector", b =>
                {
                    b.HasOne("Sectors.Shared.Sector", "Sector")
                        .WithMany("Users")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sectors.Shared.User", "User")
                        .WithMany("Sectors")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sector");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Sectors.Shared.Sector", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Sectors.Shared.User", b =>
                {
                    b.Navigation("Sectors");
                });
#pragma warning restore 612, 618
        }
    }
}
