using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "771b552d-5792-40b6-afc4-83fbbgd383f7", null, "Administrator", "ADMINISTRATOR" },
                    { "999c552d-5812-40d6-afc4-83feegd383f9", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "771b467d-5362-40b6-afc4-83f339d383f7", 0, "d38c354b-15a2-44da-81dd-09dfca280c9a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "peshtaco@gmail.com", false, "System", "User", false, null, "PESHTACO@GMAIL.COM", null, "AQAAAAIAAYagAAAAEGU+e4dBtdkGRKAyuT0nTXsBg3/dC6GcFNuUvOtc16+zSHMiq2S809YzXf+I6dFcOg==", null, false, "fb499ede-e1f3-4b21-8cff-ae0a24867eba", null, false, null },
                    { "f059abae-4be1-42ca-8c74-40d702aebac4", 0, "22655dd6-f098-41eb-8f97-b4333af2aa23", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "admin@leavemgt.com", false, "System", "Admin", false, null, "ADMIN@LEAVEMGT.COM", null, "AQAAAAIAAYagAAAAEDCOvMisUyGDDBJZlPNuGGxQf8i/qH0BarlPQQLw885CzqXEK/U394HbCtKRfQyQUg==", null, false, "da4d4132-2a17-421a-9827-17369ea1cf04", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "999c552d-5812-40d6-afc4-83feegd383f9", "771b467d-5362-40b6-afc4-83f339d383f7" },
                    { "771b552d-5792-40b6-afc4-83fbbgd383f7", "f059abae-4be1-42ca-8c74-40d702aebac4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "999c552d-5812-40d6-afc4-83feegd383f9", "771b467d-5362-40b6-afc4-83f339d383f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "771b552d-5792-40b6-afc4-83fbbgd383f7", "f059abae-4be1-42ca-8c74-40d702aebac4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "771b552d-5792-40b6-afc4-83fbbgd383f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "999c552d-5812-40d6-afc4-83feegd383f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "771b467d-5362-40b6-afc4-83f339d383f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f059abae-4be1-42ca-8c74-40d702aebac4");
        }
    }
}
