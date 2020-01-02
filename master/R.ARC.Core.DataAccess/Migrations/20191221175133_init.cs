using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace R.ARC.Core.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "tAddress",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    AddressType = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 500, nullable: false),
                    County = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: false),
                    ZipCode = table.Column<int>(nullable: false),
                    LevelCodeStr = table.Column<string>(nullable: true),
                    LevelStr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tAddressMapping",
                schema: "dbo",
                columns: table => new
                {
                    CountryCode = table.Column<string>(nullable: false),
                    Depth = table.Column<int>(nullable: false),
                    RegionSequence = table.Column<int>(nullable: true),
                    CitySequence = table.Column<int>(nullable: true),
                    CountySequence = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tAddressMapping", x => x.CountryCode);
                });

            migrationBuilder.CreateTable(
                name: "tTask",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    ExtendedData = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    StartTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    AdditionalInfo = table.Column<string>(maxLength: 255, nullable: true),
                    TaskPriority = table.Column<int>(nullable: false),
                    TaskType = table.Column<int>(nullable: false),
                    TaskStatus = table.Column<int>(nullable: false),
                    TaskModelType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tUser",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    ExtendedData = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(maxLength: 255, nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "tAddressMapping",
                columns: new[] { "CountryCode", "CitySequence", "CountySequence", "Depth", "RegionSequence" },
                values: new object[,]
                {
                    { "TR", 2, 3, 3, null },
                    { "DE", 4, 5, 5, 2 },
                    { "US", 4, null, 4, 2 },
                    { "GB", 4, 5, 5, 2 },
                    { "FR", 5, 6, 7, 2 },
                    { "VA", null, null, 1, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tAddress",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tAddressMapping",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tTask",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tUser",
                schema: "dbo");
        }
    }
}
