using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "771b467d-5362-40b6-afc4-83f339d383f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29df9803-76b6-4bd4-968e-8e9f0f75652b", "AQAAAAIAAYagAAAAEMQL/iTTdC5mOSkq8QehzSlCRGHXotOaCdtPFB5s3PUvgC8oYE6ckZ5m7EV+ks3RHg==", "6da4a12b-552f-4cc8-a5d4-2a597b58be09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f059abae-4be1-42ca-8c74-40d702aebac4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52cd95c8-250b-462e-8bd2-a1609d709fa6", "AQAAAAIAAYagAAAAEBrncXZdAdokMkK1r7BqI2oERkR5Dfga7Lc99HC9MpUQhz6qP6BJT5dPr6Boxc6SEg==", "eeba96af-d400-48c9-9a91-a275215fc412" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "771b467d-5362-40b6-afc4-83f339d383f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1131c688-7858-4e07-9112-88761bae34d3", "AQAAAAIAAYagAAAAELv6Wm7F6guibLvBDvGP17cWCZLLCKNp/lwaeSNT139dEX+LqwsN6AXg9NAtGpRvIQ==", "5d9357bc-c40f-4373-9ece-299e15436e81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f059abae-4be1-42ca-8c74-40d702aebac4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8860083b-815e-426e-bc99-4c71883e3e16", "AQAAAAIAAYagAAAAEMOEj/3ch27BDIwGTauuQPkIOB0ewAHsjN6JAKX51BoZsQe6QoHbNEZdeiM5CdfQqA==", "ea9b0d04-9b61-45d2-b09e-3c87bb66c783" });
        }
    }
}
