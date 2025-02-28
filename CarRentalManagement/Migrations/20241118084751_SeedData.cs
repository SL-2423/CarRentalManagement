﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3279), new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3296), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3300), new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3301), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3596), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3598), new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3599), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3741), new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3742), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3745), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3747), new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3747), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3749), new DateTime(2024, 11, 18, 16, 47, 50, 227, DateTimeKind.Local).AddTicks(3750), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
