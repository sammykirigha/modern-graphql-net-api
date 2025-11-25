using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateduserstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BusinessDescription",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessName",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NationalIdentityCardImage",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessDescription",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropColumn(
                name: "BusinessName",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropColumn(
                name: "NationalIdentityCardImage",
                schema: "sp",
                table: "SP_ServiceProviderEntity");
        }
    }
}
