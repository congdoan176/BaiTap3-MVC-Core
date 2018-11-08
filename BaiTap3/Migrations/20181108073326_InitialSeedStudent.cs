using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiTap3.Migrations
{
    public partial class InitialSeedStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreatedAt", "Email", "FirstName", "LastName", "Status", "UpdatedAt" },
                values: new object[] { "D00123", new DateTime(2018, 11, 8, 14, 33, 25, 501, DateTimeKind.Local), "doan@gmail.com", "Doan", "Cong", 1, new DateTime(2018, 11, 8, 14, 33, 25, 502, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreatedAt", "Email", "FirstName", "LastName", "Status", "UpdatedAt" },
                values: new object[] { "D001234", new DateTime(2018, 11, 8, 14, 33, 25, 502, DateTimeKind.Local), "doan1@gmail.com", "Doan1", "Nguyen", 1, new DateTime(2018, 11, 8, 14, 33, 25, 502, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "RollNumber", "CreatedAt", "Email", "FirstName", "LastName", "Status", "UpdatedAt" },
                values: new object[] { "D001235", new DateTime(2018, 11, 8, 14, 33, 25, 502, DateTimeKind.Local), "doan2@gmail.com", "Doan2", "Doan", 1, new DateTime(2018, 11, 8, 14, 33, 25, 502, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Mark",
                columns: new[] { "Id", "StudentRollNumber", "SubjectMark", "SubjectName" },
                values: new object[,]
                {
                    { 1, "D00123", 5, "Java" },
                    { 2, "D00123", 15, "C#" },
                    { 3, "D001234", 15, "Java" },
                    { 4, "D001234", 10, "HTML" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mark",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D001235");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D00123");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "RollNumber",
                keyValue: "D001234");
        }
    }
}
