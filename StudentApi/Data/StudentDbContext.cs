using System;
using Microsoft.EntityFrameworkCore;
using StudentLibrary;

public class StudentDbContext : DbContext {
  public DbSet<Student> Students { get; set; }

  public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    builder.Entity<Student>().HasData(
      new {
        BcitId = "A00123456",
        FirstName = "Jim",
        LastName = "Potter",
        MobileNumber = "604-123-4567",
        EmailAddress = "jim@potter.com",
        CityOfResidence = "Chilliwack",
        Specialization = "Nursing"
      }, new {
        BcitId = "A00123457",
        FirstName = "Jane",
        LastName = "Douglas",
        MobileNumber = "604-837-4024",
        EmailAddress = "jane@douglas.com",
        CityOfResidence = "Coquitlam",
        Specialization = "Geology"
      }, new {
        BcitId = "A00123458",
        FirstName = "Tom",
        LastName = "Gardner",
        MobileNumber = "604-242-6720",
        EmailAddress = "tom@gardner.com",
        CityOfResidence = "Burnaby",
        Specialization = "Nursing"
      }, new {
        BcitId = "A00123459",
        FirstName = "Ann",
        LastName = "Lee",
        MobileNumber = "778-345-0294",
        EmailAddress = "ann@lee.com",
        CityOfResidence = "New Westminster",
        Specialization = "Science"
      }, new {
        BcitId = "A00123460",
        FirstName = "James",
        LastName = "Jones",
        MobileNumber = "778-543-7563",
        EmailAddress = "james@jones.com",
        CityOfResidence = "Vancouver",
        Specialization = "Forestry"
      }, new {
        BcitId = "A00123461",
        FirstName = "Susan",
        LastName = "Taylor",
        MobileNumber = "604-287-1653",
        EmailAddress = "susan@taylor.com",
        CityOfResidence = "Richmond",
        Specialization = "Computing"
      }, new {
        BcitId = "A00123462",
        FirstName = "Peter",
        LastName = "White",
        MobileNumber = "604-420-6452",
        EmailAddress = "peter@white.com",
        CityOfResidence = "West Vancouver",
        Specialization = "Business"
      }, new {
        BcitId = "A00123463",
        FirstName = "Philip",
        LastName = "Fox",
        MobileNumber = "250-849-9284",
        EmailAddress = "philip@fox.com",
        CityOfResidence = "Surrey",
        Specialization = "Engineering"
      }, new {
        BcitId = "A00123464",
        FirstName = "Donna",
        LastName = "Ray",
        MobileNumber = "250-636-3574",
        EmailAddress = "donna@ray.com",
        CityOfResidence = "North Vancouver",
        Specialization = "Hospitality"
      }
    );
  }
}