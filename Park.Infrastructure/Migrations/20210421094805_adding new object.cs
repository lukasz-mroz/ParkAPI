using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Park.Infrastructure.Migrations
{
    public partial class addingnewobject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "Id",
                keyValue: new Guid("10f28194-2993-4ae1-b8d8-87e8106320a0"));

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4"),
                columns: new[] { "Created", "Established", "Name" },
                values: new object[] { new DateTime(2021, 4, 21, 11, 48, 4, 622, DateTimeKind.Local).AddTicks(1887), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Local), "" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Created", "Established", "IsDeleted", "Name", "State" },
                values: new object[] { new Guid("e8ed2471-726f-4ba9-b9df-8b4edaf8c9f1"), new DateTime(2021, 4, 21, 9, 48, 4, 627, DateTimeKind.Utc).AddTicks(3152), new DateTime(1990, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Bieszczady", "Podkarpackie Voivodeship" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Created", "Established", "IsDeleted", "Name", "State" },
                values: new object[] { new Guid("2849cfba-9407-4faf-bc85-e5a30b7e15d9"), new DateTime(2021, 4, 21, 11, 48, 4, 625, DateTimeKind.Local).AddTicks(8230), new DateTime(1990, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Kapiniak", "MazovianVoivodeship" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "Id",
                keyValue: new Guid("2849cfba-9407-4faf-bc85-e5a30b7e15d9"));

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "Id",
                keyValue: new Guid("e8ed2471-726f-4ba9-b9df-8b4edaf8c9f1"));

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "Id",
                keyValue: new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4"),
                columns: new[] { "Created", "Established", "Name" },
                values: new object[] { new DateTime(2021, 3, 7, 15, 23, 27, 753, DateTimeKind.Local).AddTicks(7600), new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "MyName" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Created", "Established", "IsDeleted", "Name", "State" },
                values: new object[] { new Guid("10f28194-2993-4ae1-b8d8-87e8106320a0"), new DateTime(1990, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 4, 27, 21, 33, 21, 10, DateTimeKind.Unspecified).AddTicks(1111), true, "Alabama", "my Dear Frodo Back and Again" });
        }
    }
}
