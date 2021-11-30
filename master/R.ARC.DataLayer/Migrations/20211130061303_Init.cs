using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace R.ARC.Core.DataLayer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateSequence(
                name: "seq_task_no",
                startValue: 1111111111L,
                incrementBy: 3);

            migrationBuilder.CreateTable(
                name: "Addresses",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    AddressType = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    County = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Region = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: false),
                    ZipCode = table.Column<int>(type: "integer", nullable: false),
                    LevelCodeStr = table.Column<string>(type: "text", nullable: true),
                    LevelStr = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressMappings",
                schema: "public",
                columns: table => new
                {
                    CountryCode = table.Column<string>(type: "text", nullable: false),
                    Depth = table.Column<int>(type: "integer", nullable: false),
                    RegionSequence = table.Column<int>(type: "integer", nullable: true),
                    CitySequence = table.Column<int>(type: "integer", nullable: true),
                    CountySequence = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressMappings", x => x.CountryCode);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Email = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Username = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExtendedData = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    TaskNo = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "nextval('seq_task_no')"),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AdditionalInfo = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TaskPriority = table.Column<int>(type: "integer", nullable: false),
                    TaskType = table.Column<int>(type: "integer", nullable: false),
                    TaskStatus = table.Column<int>(type: "integer", nullable: false),
                    TaskModelType = table.Column<int>(type: "integer", nullable: false),
                    RelatedTasks = table.Column<long[]>(type: "bigint[]", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExtendedData = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "AddressMappings",
                columns: new[] { "CountryCode", "CitySequence", "CountySequence", "Depth", "RegionSequence" },
                values: new object[,]
                {
                    { "DE", 4, 5, 5, 2 },
                    { "FR", 5, 6, 7, 2 },
                    { "GB", 4, 5, 5, 2 },
                    { "TR", 2, 3, 3, null },
                    { "US", 4, null, 4, 2 },
                    { "VA", null, null, 1, null }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreationTime", "Email", "ExtendedData", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "UpdateTime", "UpdatedBy", "Username" },
                values: new object[] { new Guid("2e5afee9-e189-41c1-a4f5-4e700f10eec6"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 11, 30, 6, 13, 3, 770, DateTimeKind.Utc).AddTicks(2224), "anliridvan@hotmail.com", "{\"AddressList\":[{\"AddressType\":1,\"Address\":\"Cevirmeci / Ortakoy - Istanbul\",\"County\":\"Besiktas\",\"City\":\"Istanbul\",\"Region\":\"Marmara\",\"Country\":\"TR\",\"ZipCode\":34930,\"LevelCodeStr\":null,\"LevelCode\":null,\"LevelStr\":null,\"Level\":null,\"Id\":\"00000000-0000-0000-0000-000000000000\",\"CreatedBy\":\"00000000-0000-0000-0000-000000000000\",\"CreationTime\":\"2021-11-30T06:13:03.7702226Z\",\"UpdatedBy\":\"00000000-0000-0000-0000-000000000000\",\"UpdateTime\":null,\"IsDeleted\":false}]}", "Ridvan", false, "Anli", new byte[] { 166, 143, 177, 30, 223, 236, 9, 155, 81, 33, 60, 39, 191, 174, 43, 136, 135, 126, 24, 255, 147, 195, 205, 155, 4, 31, 127, 167, 41, 94, 86, 242, 212, 7, 71, 100, 83, 150, 230, 46, 193, 133, 121, 1, 135, 170, 232, 19, 191, 161, 120, 28, 166, 213, 175, 173, 243, 203, 142, 21, 76, 78, 38, 114 }, new byte[] { 116, 207, 58, 93, 30, 236, 63, 119, 194, 207, 238, 178, 245, 247, 77, 68, 121, 183, 133, 141, 213, 181, 76, 208, 196, 182, 246, 228, 105, 154, 178, 17, 179, 2, 229, 104, 102, 194, 223, 243, 146, 223, 43, 137, 173, 85, 133, 113, 107, 53, 120, 78, 111, 34, 234, 178, 57, 33, 84, 169, 242, 92, 151, 124, 168, 107, 146, 232, 120, 21, 45, 89, 140, 160, 170, 202, 141, 160, 156, 188, 195, 208, 183, 54, 34, 196, 191, 161, 228, 112, 177, 236, 159, 38, 235, 91, 4, 168, 246, 47, 67, 108, 219, 22, 221, 203, 102, 33, 130, 134, 87, 212, 94, 202, 247, 243, 150, 162, 168, 93, 4, 71, 11, 212, 232, 73, 164, 57 }, null, new Guid("00000000-0000-0000-0000-000000000000"), "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                schema: "public",
                table: "Tasks",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses",
                schema: "public");

            migrationBuilder.DropTable(
                name: "AddressMappings",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Tasks",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "public");

            migrationBuilder.DropSequence(
                name: "seq_task_no");
        }
    }
}
