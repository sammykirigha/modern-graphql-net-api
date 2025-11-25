using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateuserstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessGlobalSettings",
                schema: "sp",
                table: "SP_User");

            migrationBuilder.DropColumn(
                name: "AccessLevel",
                schema: "sp",
                table: "SP_User");

            migrationBuilder.DropColumn(
                name: "AccessType",
                schema: "sp",
                table: "SP_User");

            migrationBuilder.DropColumn(
                name: "AdminLoginDate",
                schema: "sp",
                table: "SP_User");

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("17ff54a6-9d9a-45dc-95ea-10b68b9e6378"),
                column: "Phone",
                value: "");

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("4315515f-9932-49b7-a01d-7261047ed1c9"),
                column: "Phone",
                value: "");

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("dcfaff46-e2c3-4b3d-ba44-dfe86b9dfcd3"),
                column: "Phone",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AccessGlobalSettings",
                schema: "sp",
                table: "SP_User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte>(
                name: "AccessLevel",
                schema: "sp",
                table: "SP_User",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "AccessType",
                schema: "sp",
                table: "SP_User",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "AdminLoginDate",
                schema: "sp",
                table: "SP_User",
                type: "datetime2(3)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("17ff54a6-9d9a-45dc-95ea-10b68b9e6378"),
                columns: new[] { "AccessGlobalSettings", "AccessLevel", "AccessType", "AdminLoginDate", "Phone" },
                values: new object[] { false, (byte)0, (byte)0, null, null });

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("4315515f-9932-49b7-a01d-7261047ed1c9"),
                columns: new[] { "AccessGlobalSettings", "AccessLevel", "AccessType", "AdminLoginDate", "Phone" },
                values: new object[] { false, (byte)1, (byte)1, null, null });

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("dcfaff46-e2c3-4b3d-ba44-dfe86b9dfcd3"),
                columns: new[] { "AccessGlobalSettings", "AccessLevel", "AccessType", "AdminLoginDate", "Phone" },
                values: new object[] { false, (byte)2, (byte)0, null, null });
        }
    }
}
