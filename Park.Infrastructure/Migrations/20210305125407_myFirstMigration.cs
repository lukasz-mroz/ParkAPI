using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Park.Infrastructure.Migrations
{
    public partial class myFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Established = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Created", "Established", "Name", "State" },
                values: new object[] { new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4"), new DateTime(2021, 3, 5, 13, 54, 6, 714, DateTimeKind.Local).AddTicks(3336), new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), "MyName", "New" });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Created", "Established", "Name", "State" },
                values: new object[] { new Guid("a0dcdcee-cd26-4246-847a-ed633a86772a"), new DateTime(1990, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 4, 27, 21, 33, 21, 10, DateTimeKind.Unspecified).AddTicks(1111), "Alabama", "my Dear FrodoBack and Again" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
