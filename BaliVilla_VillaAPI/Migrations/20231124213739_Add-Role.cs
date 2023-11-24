using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaliVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rola",
                table: "LocalUsers",
                newName: "Role");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 24, 18, 37, 38, 515, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 24, 18, 37, 38, 515, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 24, 18, 37, 38, 516, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 24, 18, 37, 38, 516, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 24, 18, 37, 38, 516, DateTimeKind.Local).AddTicks(28));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "LocalUsers",
                newName: "Rola");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 18, 11, 58, 493, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 18, 11, 58, 493, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 18, 11, 58, 493, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 18, 11, 58, 493, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 18, 11, 58, 493, DateTimeKind.Local).AddTicks(4255));
        }
    }
}
