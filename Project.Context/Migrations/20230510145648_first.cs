using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Context.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coronaDetailss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstVaccination = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SecondVaccination = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThreeVaccination = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FourthVaccination = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstProducer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondProducer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThreeProducer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FourthProducer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfPositiveResult = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfRecovery = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coronaDetailss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personalDetailss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetNum = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personalDetailss", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coronaDetailss");

            migrationBuilder.DropTable(
                name: "personalDetailss");
        }
    }
}
