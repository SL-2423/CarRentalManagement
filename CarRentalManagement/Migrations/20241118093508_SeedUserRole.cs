using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a2775cc4-e48e-4963-be58-03b571575ae0", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIxX9YghV1EDP3eVOamy/QRzjX6NoK92F2ULzE9BheG9iw6ybToGp0bHcd9k7taOdQ==", null, false, "20bbd890-7065-42db-aeaa-8046fbc64d9d", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8462), new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8800), new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8803), new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8954), new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8957), new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8959), new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8961), new DateTime(2024, 11, 18, 17, 35, 7, 425, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3273), new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3297), new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3552), new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3555), new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3697), new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3700), new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 11, 18, 17, 12, 6, 836, DateTimeKind.Local).AddTicks(3703) });
        }
    }
}
