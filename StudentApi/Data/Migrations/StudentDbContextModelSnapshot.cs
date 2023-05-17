﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace StudentApi.Data.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("StudentLibrary.Student", b =>
                {
                    b.Property<string>("BcitId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CityOfResidence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BcitId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            BcitId = "A00123456",
                            CityOfResidence = "Chilliwack",
                            EmailAddress = "jim@potter.com",
                            FirstName = "Jim",
                            LastName = "Potter",
                            MobileNumber = "604-123-4567",
                            Specialization = "Nursing"
                        },
                        new
                        {
                            BcitId = "A00123457",
                            CityOfResidence = "Coquitlam",
                            EmailAddress = "jane@douglas.com",
                            FirstName = "Jane",
                            LastName = "Douglas",
                            MobileNumber = "604-837-4024",
                            Specialization = "Geology"
                        },
                        new
                        {
                            BcitId = "A00123458",
                            CityOfResidence = "Burnaby",
                            EmailAddress = "tom@gardner.com",
                            FirstName = "Tom",
                            LastName = "Gardner",
                            MobileNumber = "604-242-6720",
                            Specialization = "Nursing"
                        },
                        new
                        {
                            BcitId = "A00123459",
                            CityOfResidence = "New Westminster",
                            EmailAddress = "ann@lee.com",
                            FirstName = "Ann",
                            LastName = "Lee",
                            MobileNumber = "778-345-0294",
                            Specialization = "Science"
                        },
                        new
                        {
                            BcitId = "A00123460",
                            CityOfResidence = "Vancouver",
                            EmailAddress = "james@jones.com",
                            FirstName = "James",
                            LastName = "Jones",
                            MobileNumber = "778-543-7563",
                            Specialization = "Forestry"
                        },
                        new
                        {
                            BcitId = "A00123461",
                            CityOfResidence = "Richmond",
                            EmailAddress = "susan@taylor.com",
                            FirstName = "Susan",
                            LastName = "Taylor",
                            MobileNumber = "604-287-1653",
                            Specialization = "Computing"
                        },
                        new
                        {
                            BcitId = "A00123462",
                            CityOfResidence = "West Vancouver",
                            EmailAddress = "peter@white.com",
                            FirstName = "Peter",
                            LastName = "White",
                            MobileNumber = "604-420-6452",
                            Specialization = "Business"
                        },
                        new
                        {
                            BcitId = "A00123463",
                            CityOfResidence = "Surrey",
                            EmailAddress = "philip@fox.com",
                            FirstName = "Philip",
                            LastName = "Fox",
                            MobileNumber = "250-849-9284",
                            Specialization = "Engineering"
                        },
                        new
                        {
                            BcitId = "A00123464",
                            CityOfResidence = "North Vancouver",
                            EmailAddress = "donna@ray.com",
                            FirstName = "Donna",
                            LastName = "Ray",
                            MobileNumber = "250-636-3574",
                            Specialization = "Hospitality"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}