using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaId",
                table: "VillasNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 22, 55, 38, 406, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 22, 55, 38, 406, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 22, 55, 38, 406, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 22, 55, 38, 406, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 22, 55, 38, 406, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.CreateIndex(
                name: "IX_VillasNumbers_VillaId",
                table: "VillasNumbers",
                column: "VillaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VillasNumbers_Villas_VillaId",
                table: "VillasNumbers",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillasNumbers_Villas_VillaId",
                table: "VillasNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillasNumbers_VillaId",
                table: "VillasNumbers");

            migrationBuilder.DropColumn(
                name: "VillaId",
                table: "VillasNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 15, 1, 28, 351, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 15, 1, 28, 351, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 15, 1, 28, 351, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 15, 1, 28, 351, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 29, 15, 1, 28, 351, DateTimeKind.Local).AddTicks(920));
        }
    }
}
