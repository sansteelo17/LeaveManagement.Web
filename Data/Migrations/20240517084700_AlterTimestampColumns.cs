using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTimestampColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                           name: "DateCreated",
                           table: "LeaveTypes",
                           type: "timestamp without time zone",
                           nullable: false,
                           oldClrType: typeof(DateTime),
                           oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "LeaveTypes",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                        name: "DateCreated",
                        table: "LeaveAllocations",
                        type: "timestamp without time zone",
                        nullable: false,
                        oldClrType: typeof(DateTime),
                        oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "LeaveAllocations",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
            name: "DateOfBirth",
            table: "AspNetUsers",
            type: "timestamp without time zone",
            nullable: false,
            oldClrType: typeof(DateTime),
            oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
            name: "DateJoined",
            table: "AspNetUsers",
            type: "timestamp without time zone",
            nullable: false,
            oldClrType: typeof(DateTime),
            oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                          name: "DateCreated",
                          table: "LeaveTypes",
                          type: "timestamp with time zone",
                          nullable: false,
                          oldClrType: typeof(DateTime),
                          oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "LeaveTypes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                     name: "DateCreated",
                     table: "LeaveAllocations",
                     type: "timestamp with time zone",
                     nullable: false,
                     oldClrType: typeof(DateTime),
                     oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "LeaveAllocations",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                       name: "DateOfBirth",
                       table: "AspNetUsers",
                       type: "timestamp with time zone",
                       nullable: false,
                       oldClrType: typeof(DateTime),
                       oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");
        }
    }
}
