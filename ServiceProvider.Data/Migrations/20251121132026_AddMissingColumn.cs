using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                schema: "sp",
                table: "SP_User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("17ff54a6-9d9a-45dc-95ea-10b68b9e6378"),
                column: "Password",
                value: "AdminPassword123!");

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("4315515f-9932-49b7-a01d-7261047ed1c9"),
                column: "Password",
                value: "AdminPassword123!");

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("dcfaff46-e2c3-4b3d-ba44-dfe86b9dfcd3"),
                column: "Password",
                value: "AdminPassword123!");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                schema: "sp",
                table: "SP_User");
        }
    }
}
