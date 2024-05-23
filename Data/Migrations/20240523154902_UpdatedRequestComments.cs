using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "771b467d-5362-40b6-afc4-83f339d383f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1aee3e8-2a20-4726-9ea0-590fed06854c", "AQAAAAIAAYagAAAAEGPJC2vtNymqLeD49duQ16xofI1p2UK3YyKiXDjVDkeBmf2v9iBFnZMdbk8yrvoabg==", "2404158b-5e1e-4e25-b0ae-c930a1bea7ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f059abae-4be1-42ca-8c74-40d702aebac4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec7fa1a3-de22-4bbc-afea-1732c40de4a6", "AQAAAAIAAYagAAAAEAUWk/fv2shXG0G/Vg9S+POoHe5FubQJstXNS6nFrKNzVrkknxFZHEX4D+tlilFLlw==", "0e1c7ff8-32c0-4a14-84ab-feb0860b8c0e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "771b467d-5362-40b6-afc4-83f339d383f7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e74a05db-8724-43a0-ba53-84e6d77538b2", "AQAAAAIAAYagAAAAELRje38laQPjynjonCOe+s7CCBBE3YlMBAEjQkD7KkNiXC6EZ6HnV4s4gl2mxh5EcQ==", "18268dcb-af97-4481-970b-5d24a5c687ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f059abae-4be1-42ca-8c74-40d702aebac4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a37c3e0f-30b8-4482-b901-8e11eab504cb", "AQAAAAIAAYagAAAAEH7WTPh8MdNDPPczvG5xWYyp0eQfuqBWsruMB0DOK0R2rfbGFyf82aCfyJyobVU8OA==", "b41b9642-8b4d-48eb-9e03-a81f11a26231" });
        }
    }
}
