using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "integer", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RequestComments = table.Column<string>(type: "text", nullable: false),
                    Approved = table.Column<bool>(type: "boolean", nullable: true),
                    Cancelled = table.Column<bool>(type: "boolean", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
