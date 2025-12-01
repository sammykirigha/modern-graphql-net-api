using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_ServiceProviderEntity_SP_Location_LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropColumn(
                name: "NationalIdentityCardImage",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.AlterColumn<Guid>(
                name: "LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "SP_Media",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Media", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ServiceProviderEntity_SP_Location_LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                column: "LocationId",
                principalSchema: "sp",
                principalTable: "SP_Location",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_ServiceProviderEntity_SP_Location_LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropTable(
                name: "SP_Media",
                schema: "sp");

            migrationBuilder.AlterColumn<Guid>(
                name: "LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalIdentityCardImage",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ServiceProviderEntity_SP_Location_LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                column: "LocationId",
                principalSchema: "sp",
                principalTable: "SP_Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
