﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonelSystem.Data;

#nullable disable

namespace PersonelSystem.Migrations
{
    [DbContext(typeof(SystemDbContext))]
    [Migration("20220929123431_GenderSeperatedToModel")]
    partial class GenderSeperatedToModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PersonelSystem.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Economy"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Sales"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "It"
                        },
                        new
                        {
                            DepartmentId = 5,
                            DepartmentName = "Management"
                        },
                        new
                        {
                            DepartmentId = 6,
                            DepartmentName = "Administration"
                        });
                });

            modelBuilder.Entity("PersonelSystem.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"), 1L, 1);

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("Gender");

                    b.HasData(
                        new
                        {
                            GenderId = 1,
                            GenderName = "Female"
                        },
                        new
                        {
                            GenderId = 2,
                            GenderName = "Male"
                        },
                        new
                        {
                            GenderId = 3,
                            GenderName = "Other"
                        });
                });

            modelBuilder.Entity("PersonelSystem.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StreetAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("GenderId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            StaffId = 1,
                            City = "Varberg",
                            DepartmentId = 4,
                            Email = "eline@mail.com",
                            FirstName = "Elin",
                            GenderId = 1,
                            LastName = "Ericstam",
                            PhoneNumber = "070-12312312",
                            Salary = 30000m,
                            StreetAdress = "Gatan 2",
                            ZipCode = "43237"
                        },
                        new
                        {
                            StaffId = 2,
                            City = "Göteborg",
                            DepartmentId = 2,
                            Email = "oskarj@mail.com",
                            FirstName = "Oskar",
                            GenderId = 2,
                            LastName = "Johansson",
                            PhoneNumber = "070-12312343",
                            Salary = 32000m,
                            StreetAdress = "Gatan 5",
                            ZipCode = "43243"
                        },
                        new
                        {
                            StaffId = 3,
                            City = "Kungsbacka",
                            DepartmentId = 5,
                            Email = "michaels@mail.com",
                            FirstName = "Michael",
                            GenderId = 2,
                            LastName = "Scott",
                            PhoneNumber = "070-43212312",
                            Salary = 30000m,
                            StreetAdress = "Vägen 12",
                            ZipCode = "42345"
                        },
                        new
                        {
                            StaffId = 4,
                            City = "Göteborg",
                            DepartmentId = 6,
                            Email = "pamb@mail.com",
                            FirstName = "Pam",
                            GenderId = 1,
                            LastName = "Beesly",
                            PhoneNumber = "070-12357312",
                            Salary = 33000m,
                            StreetAdress = "Vägen 32",
                            ZipCode = "43242"
                        },
                        new
                        {
                            StaffId = 5,
                            City = "Göteborg",
                            DepartmentId = 3,
                            Email = "jimh@mail.com",
                            FirstName = "Jim",
                            GenderId = 2,
                            LastName = "Halpert",
                            PhoneNumber = "070-12357398",
                            Salary = 31000m,
                            StreetAdress = "Vägen 54",
                            ZipCode = "43242"
                        },
                        new
                        {
                            StaffId = 6,
                            City = "Varberg",
                            DepartmentId = 2,
                            Email = "angelam@mail.com",
                            FirstName = "Angela",
                            GenderId = 1,
                            LastName = "Martin",
                            PhoneNumber = "070-12357312",
                            Salary = 30000m,
                            StreetAdress = "Gatan 5",
                            ZipCode = "43236"
                        },
                        new
                        {
                            StaffId = 7,
                            City = "Varberg",
                            DepartmentId = 1,
                            Email = "tobyf@mail.com",
                            FirstName = "Toby",
                            GenderId = 2,
                            LastName = "Flenderson",
                            PhoneNumber = "070-56757312",
                            Salary = 34000m,
                            StreetAdress = "Gatan 76",
                            ZipCode = "43238"
                        },
                        new
                        {
                            StaffId = 8,
                            City = "Varberg",
                            DepartmentId = 3,
                            Email = "dwights@mail.com",
                            FirstName = "Dwight",
                            GenderId = 2,
                            LastName = "Schrute",
                            PhoneNumber = "073-56123312",
                            Salary = 33000m,
                            StreetAdress = "Gatan 7",
                            ZipCode = "43236"
                        });
                });

            modelBuilder.Entity("PersonelSystem.Models.Staff", b =>
                {
                    b.HasOne("PersonelSystem.Models.Department", "Department")
                        .WithMany("Staffs")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonelSystem.Models.Gender", "Gender")
                        .WithMany("Staffs")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("PersonelSystem.Models.Department", b =>
                {
                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("PersonelSystem.Models.Gender", b =>
                {
                    b.Navigation("Staffs");
                });
#pragma warning restore 612, 618
        }
    }
}
