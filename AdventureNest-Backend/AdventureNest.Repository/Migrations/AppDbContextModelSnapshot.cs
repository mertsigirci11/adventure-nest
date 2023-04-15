﻿// <auto-generated />
using System;
using AdventureNest.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdventureNest.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AdventureNest.Core.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookingStatus")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PricePerDay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PublicationId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PublicationId");

                    b.ToTable("Bookings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookingDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(305),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(304),
                            CustomerId = 2,
                            DepartureDate = new DateTime(2023, 8, 17, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 1000m,
                            PublicationId = 1,
                            TotalPrice = 6000m
                        },
                        new
                        {
                            Id = 2,
                            BookingDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(466),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 9, 5, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(465),
                            CustomerId = 3,
                            DepartureDate = new DateTime(2023, 9, 9, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 4000m,
                            PublicationId = 2,
                            TotalPrice = 16000m
                        },
                        new
                        {
                            Id = 3,
                            BookingDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(476),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 10, 21, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(476),
                            CustomerId = 1,
                            DepartureDate = new DateTime(2023, 10, 27, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 800m,
                            PublicationId = 3,
                            TotalPrice = 48000m
                        },
                        new
                        {
                            Id = 4,
                            BookingDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(485),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(485),
                            CustomerId = 3,
                            DepartureDate = new DateTime(2023, 8, 10, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 1000m,
                            PublicationId = 4,
                            TotalPrice = 10000m
                        },
                        new
                        {
                            Id = 5,
                            BookingDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(493),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 8, 11, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(493),
                            CustomerId = 1,
                            DepartureDate = new DateTime(2023, 8, 17, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 2500m,
                            PublicationId = 5,
                            TotalPrice = 15000m
                        },
                        new
                        {
                            Id = 6,
                            BookingDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(502),
                            BookingStatus = "Booked",
                            CheckInDate = new DateTime(2023, 5, 8, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(501),
                            CustomerId = 2,
                            DepartureDate = new DateTime(2023, 5, 12, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            PricePerDay = 200m,
                            PublicationId = 6,
                            TotalPrice = 800m
                        });
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("BathroomCount")
                        .HasColumnType("int");

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<int>("BedroomCount")
                        .HasColumnType("int");

                    b.Property<string>("BookingType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsChair")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDishwasher")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFridge")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSofa")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTv")
                        .HasColumnType("bit");

                    b.Property<float>("Latitude")
                        .HasColumnType("real");

                    b.Property<float>("Longtitude")
                        .HasColumnType("real");

                    b.Property<int>("MaxGuestCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PhotographsPathList")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Properties", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Serdivan",
                            BathroomCount = 5,
                            BedCount = 12,
                            BedroomCount = 6,
                            BookingType = "Full House",
                            City = "Sakarya",
                            Country = "Turkey",
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(639),
                            IsChair = true,
                            IsDishwasher = true,
                            IsFridge = true,
                            IsSofa = true,
                            IsTable = true,
                            IsTv = true,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 15,
                            Name = "Serdivan Villa",
                            OwnerId = 1,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Villa"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Miami Beach",
                            BathroomCount = 5,
                            BedCount = 8,
                            BedroomCount = 5,
                            BookingType = "Villa",
                            City = "Miami",
                            Country = "USA",
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(642),
                            IsChair = true,
                            IsDishwasher = true,
                            IsFridge = true,
                            IsSofa = true,
                            IsTable = true,
                            IsTv = true,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 10,
                            Name = "Miami Villa",
                            OwnerId = 1,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Villa"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Kadikoy",
                            BathroomCount = 1,
                            BedCount = 3,
                            BedroomCount = 4,
                            BookingType = "Full House",
                            City = "Istanbul",
                            Country = "Turkey",
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(645),
                            IsChair = true,
                            IsDishwasher = true,
                            IsFridge = true,
                            IsSofa = true,
                            IsTable = true,
                            IsTv = true,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 4,
                            Name = "Istanbul Kadikoy House",
                            OwnerId = 2,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Flat"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Sosun Magu",
                            BathroomCount = 1,
                            BedCount = 2,
                            BedroomCount = 2,
                            BookingType = "Full House",
                            City = "Hithadhoo",
                            Country = "Maldives",
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(647),
                            IsChair = true,
                            IsDishwasher = false,
                            IsFridge = true,
                            IsSofa = false,
                            IsTable = true,
                            IsTv = true,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 4,
                            Name = "Maldives Bungalow",
                            OwnerId = 2,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Villa"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Capitana",
                            BathroomCount = 2,
                            BedCount = 2,
                            BedroomCount = 2,
                            BookingType = "Full House",
                            City = "Cagliari",
                            Country = "Italy",
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(684),
                            IsChair = true,
                            IsDishwasher = true,
                            IsFridge = true,
                            IsSofa = true,
                            IsTable = true,
                            IsTv = true,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 3,
                            Name = "Sardinia Hotel Room",
                            OwnerId = 3,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Hotel"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Champ-Elysee",
                            BathroomCount = 1,
                            BedCount = 1,
                            BedroomCount = 1,
                            BookingType = "Single Room",
                            City = "Paris",
                            Country = "France",
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(688),
                            IsChair = false,
                            IsDishwasher = true,
                            IsFridge = true,
                            IsSofa = true,
                            IsTable = false,
                            IsTv = false,
                            Latitude = 0f,
                            Longtitude = 0f,
                            MaxGuestCount = 2,
                            Name = "Paris Studio",
                            OwnerId = 3,
                            PhotographsPathList = "path1,path2,path3,path4,path5",
                            PropertyType = "Flat"
                        });
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId")
                        .IsUnique();

                    b.ToTable("Publications", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(30),
                            Description = "Villa with Sapanca Lake view",
                            Header = "Sakarya Lux Villa House",
                            IsActive = true,
                            Price = 1000m,
                            PropertyId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(40),
                            Description = "Villa with Miami Beach view",
                            Header = "Ultra Lux Villa in Miami",
                            IsActive = true,
                            Price = 4000m,
                            PropertyId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(41),
                            Description = "A beautiful house in the center of Kadıköy",
                            Header = "Comfortable House in Kadikoy",
                            IsActive = true,
                            Price = 800m,
                            PropertyId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(42),
                            Description = "Ultra luxury all-inclusive accommodation by the ocean in the Maldives",
                            Header = "Unique Villa with deep blue ocean view",
                            IsActive = true,
                            Price = 1000m,
                            PropertyId = 4
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(43),
                            Description = "A hotel room in the unique beauty of the island of Sardinia",
                            Header = "All inclusive hotel room with sea view",
                            IsActive = true,
                            Price = 2500m,
                            PropertyId = 5
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 4, 15, 16, 14, 13, 835, DateTimeKind.Local).AddTicks(44),
                            Description = "One room house",
                            Header = "Affordable studio home in Paris",
                            IsActive = true,
                            Price = 200m,
                            PropertyId = 6
                        });
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Token", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("AdventureNest.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirsName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProfilePhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthday = new DateTime(1999, 9, 19, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 9, 9, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Email = "string1@hotmail.com",
                            FirsName = "string1",
                            LastName = "string1",
                            PasswordHash = new byte[] { 112, 215, 111, 108, 228, 102, 216, 135, 42, 223, 239, 54, 141, 38, 165, 28, 16, 98, 153, 43, 49, 163, 212, 128, 110, 89, 241, 143, 105, 49, 50, 51, 103, 20, 99, 24, 124, 0, 128, 130, 224, 5, 128, 185, 14, 19, 207, 226, 137, 133, 243, 104, 250, 255, 255, 208, 227, 53, 144, 103, 240, 125, 249, 64 },
                            PasswordSalt = new byte[] { 137, 219, 177, 245, 203, 29, 80, 170, 0, 193, 52, 123, 76, 234, 119, 156, 45, 158, 85, 84, 27, 250, 22, 215, 245, 102, 161, 129, 223, 73, 207, 205, 172, 99, 195, 206, 169, 83, 168, 78, 121, 108, 188, 85, 138, 201, 20, 126, 111, 23, 190, 117, 33, 63, 20, 83, 202, 64, 232, 105, 223, 132, 174, 142, 41, 46, 252, 126, 111, 20, 235, 24, 152, 119, 110, 235, 18, 52, 146, 7, 188, 252, 72, 66, 221, 246, 35, 20, 198, 78, 107, 57, 233, 100, 7, 68, 234, 138, 48, 9, 105, 32, 15, 170, 224, 253, 154, 114, 181, 107, 48, 174, 229, 34, 166, 79, 156, 173, 134, 250, 19, 56, 139, 55, 32, 130, 207, 93 },
                            ProfilePhotoPath = "string1"
                        },
                        new
                        {
                            Id = 2,
                            Birthday = new DateTime(1998, 8, 18, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 8, 8, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Email = "string2@hotmail.com",
                            FirsName = "string2",
                            LastName = "string2",
                            PasswordHash = new byte[] { 2, 87, 38, 185, 13, 13, 156, 23, 102, 18, 133, 80, 255, 88, 127, 161, 214, 241, 113, 63, 4, 136, 112, 33, 220, 2, 127, 95, 156, 170, 35, 45, 33, 134, 43, 20, 42, 231, 175, 62, 14, 55, 2, 92, 196, 200, 248, 57, 131, 182, 7, 203, 120, 132, 7, 244, 238, 182, 169, 221, 223, 203, 14, 114 },
                            PasswordSalt = new byte[] { 190, 172, 5, 106, 144, 70, 132, 248, 28, 44, 253, 160, 172, 119, 194, 180, 173, 216, 110, 238, 17, 203, 206, 5, 227, 195, 224, 182, 211, 159, 249, 254, 165, 106, 40, 165, 118, 118, 74, 150, 242, 157, 69, 130, 160, 37, 242, 190, 51, 133, 1, 24, 232, 104, 166, 36, 26, 139, 80, 111, 199, 211, 135, 136, 195, 143, 8, 30, 72, 21, 86, 172, 173, 113, 199, 225, 181, 45, 249, 87, 63, 183, 115, 5, 170, 30, 122, 161, 44, 18, 97, 69, 4, 89, 18, 25, 45, 70, 66, 210, 15, 62, 81, 18, 46, 4, 28, 177, 37, 37, 147, 210, 73, 126, 217, 44, 2, 100, 9, 82, 65, 167, 189, 121, 191, 117, 1, 159 },
                            ProfilePhotoPath = "string2"
                        },
                        new
                        {
                            Id = 3,
                            Birthday = new DateTime(1997, 7, 17, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 7, 7, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            Email = "string3@hotmail.com",
                            FirsName = "string3",
                            LastName = "string3",
                            PasswordHash = new byte[] { 244, 94, 112, 254, 82, 181, 148, 40, 144, 128, 111, 192, 243, 9, 113, 170, 215, 254, 244, 140, 76, 6, 194, 236, 185, 65, 240, 212, 23, 152, 55, 214, 151, 85, 80, 184, 64, 171, 113, 18, 48, 184, 158, 172, 192, 161, 217, 161, 123, 105, 219, 252, 13, 214, 51, 118, 126, 163, 135, 75, 111, 247, 221, 1 },
                            PasswordSalt = new byte[] { 169, 189, 66, 133, 85, 144, 255, 129, 75, 149, 90, 155, 153, 61, 159, 161, 7, 154, 205, 74, 147, 86, 238, 182, 120, 51, 201, 123, 120, 199, 86, 255, 202, 64, 67, 173, 234, 246, 209, 199, 241, 134, 206, 0, 12, 147, 48, 233, 249, 131, 30, 125, 91, 106, 73, 53, 82, 11, 239, 225, 82, 32, 22, 34, 195, 127, 171, 62, 80, 206, 99, 50, 165, 11, 202, 41, 191, 233, 174, 22, 195, 45, 240, 180, 85, 31, 4, 79, 96, 176, 126, 174, 231, 159, 132, 198, 213, 83, 182, 125, 64, 96, 114, 158, 123, 117, 124, 168, 134, 99, 76, 45, 2, 80, 164, 192, 208, 39, 227, 227, 189, 236, 127, 0, 60, 164, 70, 122 },
                            ProfilePhotoPath = "string3"
                        });
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Booking", b =>
                {
                    b.HasOne("AdventureNest.Core.Models.Publication", "Publication")
                        .WithMany("Bookings")
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publication");
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Property", b =>
                {
                    b.HasOne("AdventureNest.Core.Models.User", "User")
                        .WithMany("Properties")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Publication", b =>
                {
                    b.HasOne("AdventureNest.Core.Models.Property", "Property")
                        .WithOne("Publication")
                        .HasForeignKey("AdventureNest.Core.Models.Publication", "PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Property", b =>
                {
                    b.Navigation("Publication")
                        .IsRequired();
                });

            modelBuilder.Entity("AdventureNest.Core.Models.Publication", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("AdventureNest.Core.Models.User", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
