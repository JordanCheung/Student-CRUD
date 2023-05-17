using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApi.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    BcitId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityOfResidence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.BcitId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "BcitId", "CityOfResidence", "EmailAddress", "FirstName", "LastName", "MobileNumber", "Specialization" },
                values: new object[,]
                {
                    { "A00123456", "Chilliwack", "jim@potter.com", "Jim", "Potter", "604-123-4567", "Nursing" },
                    { "A00123457", "Coquitlam", "jane@douglas.com", "Jane", "Douglas", "604-837-4024", "Geology" },
                    { "A00123458", "Burnaby", "tom@gardner.com", "Tom", "Gardner", "604-242-6720", "Nursing" },
                    { "A00123459", "New Westminster", "ann@lee.com", "Ann", "Lee", "778-345-0294", "Science" },
                    { "A00123460", "Vancouver", "james@jones.com", "James", "Jones", "778-543-7563", "Forestry" },
                    { "A00123461", "Richmond", "susan@taylor.com", "Susan", "Taylor", "604-287-1653", "Computing" },
                    { "A00123462", "West Vancouver", "peter@white.com", "Peter", "White", "604-420-6452", "Business" },
                    { "A00123463", "Surrey", "philip@fox.com", "Philip", "Fox", "250-849-9284", "Engineering" },
                    { "A00123464", "North Vancouver", "donna@ray.com", "Donna", "Ray", "250-636-3574", "Hospitality" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
