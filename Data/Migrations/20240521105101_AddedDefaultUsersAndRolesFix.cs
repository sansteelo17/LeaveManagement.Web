using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRolesFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "771b467d-5362-40b6-afc4-83f339d383f7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1131c688-7858-4e07-9112-88761bae34d3", true, "PESHTACO@GMAIL.COM", "AQAAAAIAAYagAAAAELv6Wm7F6guibLvBDvGP17cWCZLLCKNp/lwaeSNT139dEX+LqwsN6AXg9NAtGpRvIQ==", "5d9357bc-c40f-4373-9ece-299e15436e81", "peshtaco@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f059abae-4be1-42ca-8c74-40d702aebac4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8860083b-815e-426e-bc99-4c71883e3e16", true, "ADMIN@LEAVEMGT.COM", "AQAAAAIAAYagAAAAEMOEj/3ch27BDIwGTauuQPkIOB0ewAHsjN6JAKX51BoZsQe6QoHbNEZdeiM5CdfQqA==", "ea9b0d04-9b61-45d2-b09e-3c87bb66c783", "admin@leavemgt.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "771b467d-5362-40b6-afc4-83f339d383f7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d38c354b-15a2-44da-81dd-09dfca280c9a", false, null, "AQAAAAIAAYagAAAAEGU+e4dBtdkGRKAyuT0nTXsBg3/dC6GcFNuUvOtc16+zSHMiq2S809YzXf+I6dFcOg==", "fb499ede-e1f3-4b21-8cff-ae0a24867eba", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f059abae-4be1-42ca-8c74-40d702aebac4",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "22655dd6-f098-41eb-8f97-b4333af2aa23", false, null, "AQAAAAIAAYagAAAAEDCOvMisUyGDDBJZlPNuGGxQf8i/qH0BarlPQQLw885CzqXEK/U394HbCtKRfQyQUg==", "da4d4132-2a17-421a-9827-17369ea1cf04", null });
        }
    }
}
