using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class removedphonecolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_Payment_SP_User_UserId",
                schema: "sp",
                table: "SP_Payment");

            migrationBuilder.DropIndex(
                name: "IX_SP_Payment_UserId",
                schema: "sp",
                table: "SP_Payment");

            migrationBuilder.DropColumn(
                name: "Phone",
                schema: "sp",
                table: "SP_User");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "sp",
                table: "SP_Payment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                schema: "sp",
                table: "SP_User",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                schema: "sp",
                table: "SP_Payment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_SP_Payment_UserId",
                schema: "sp",
                table: "SP_Payment",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Payment_SP_User_UserId",
                schema: "sp",
                table: "SP_Payment",
                column: "UserId",
                principalSchema: "sp",
                principalTable: "SP_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
