using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
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
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressMappings",
                schema: "public",
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
                    table.PrimaryKey("PK_AddressMappings", x => x.CountryCode);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    ExtendedData = table.Column<string>(nullable: true),
                    TaskNo = table.Column<long>(nullable: false, defaultValueSql: "nextval('seq_task_no')"),
                    UserId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    StartTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    AdditionalInfo = table.Column<string>(maxLength: 255, nullable: true),
                    TaskPriority = table.Column<int>(nullable: false),
                    TaskType = table.Column<int>(nullable: false),
                    TaskStatus = table.Column<int>(nullable: false),
                    TaskModelType = table.Column<int>(nullable: false),
                    RelatedTasks = table.Column<long[]>(nullable: true)
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
                    { "TR", 2, 3, 3, null },
                    { "DE", 4, 5, 5, 2 },
                    { "US", 4, null, 4, 2 },
                    { "GB", 4, 5, 5, 2 },
                    { "FR", 5, 6, 7, 2 },
                    { "VA", null, null, 1, null }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreationTime", "Email", "ExtendedData", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "UpdateTime", "UpdatedBy", "Username" },
                values: new object[] { new Guid("ebb4e860-9a55-4518-9c8e-344c4883a69f"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2021, 8, 5, 15, 19, 10, 348, DateTimeKind.Utc).AddTicks(9261), "anliridvan@hotmail.com", "{\"AddressList\":[{\"AddressType\":1,\"Address\":\"Cevirmeci / Ortakoy - Istanbul\",\"County\":\"Besiktas\",\"City\":\"Istanbul\",\"Region\":\"Marmara\",\"Country\":\"TR\",\"ZipCode\":34930,\"LevelCodeStr\":null,\"LevelCode\":null,\"LevelStr\":null,\"Level\":null,\"Id\":\"00000000-0000-0000-0000-000000000000\",\"CreatedBy\":\"00000000-0000-0000-0000-000000000000\",\"CreationTime\":\"2021-08-05T15:19:10.3492384Z\",\"UpdatedBy\":\"00000000-0000-0000-0000-000000000000\",\"UpdateTime\":null,\"IsDeleted\":false}]}", "Ridvan", false, "Anli", new byte[] { 74, 106, 157, 73, 26, 132, 177, 251, 166, 238, 210, 5, 31, 14, 217, 214, 201, 6, 2, 180, 104, 130, 239, 243, 139, 151, 202, 233, 27, 79, 249, 115, 211, 206, 229, 191, 122, 151, 79, 211, 118, 89, 239, 234, 152, 214, 148, 47, 192, 198, 67, 243, 234, 79, 85, 203, 170, 73, 236, 201, 106, 223, 207, 61 }, new byte[] { 66, 72, 117, 56, 131, 48, 131, 41, 231, 121, 167, 87, 59, 90, 142, 254, 132, 248, 197, 234, 191, 54, 185, 198, 129, 5, 109, 246, 49, 182, 158, 20, 15, 252, 223, 145, 4, 93, 237, 77, 115, 216, 19, 163, 196, 107, 221, 117, 188, 207, 178, 95, 37, 57, 168, 133, 111, 96, 191, 105, 153, 49, 22, 24, 72, 201, 149, 102, 151, 120, 119, 208, 150, 139, 136, 201, 6, 64, 228, 106, 136, 198, 45, 198, 145, 73, 57, 242, 229, 51, 126, 182, 21, 106, 141, 58, 179, 242, 32, 181, 83, 3, 245, 245, 24, 55, 204, 247, 74, 33, 137, 62, 22, 7, 83, 233, 236, 59, 250, 4, 96, 236, 46, 17, 63, 51, 132, 125 }, null, new Guid("00000000-0000-0000-0000-000000000000"), "admin" });

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
