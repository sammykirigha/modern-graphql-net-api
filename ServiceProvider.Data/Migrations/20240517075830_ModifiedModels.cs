using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SP_Client_LocationId",
                schema: "sp",
                table: "SP_Client");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Client_LocationId",
                schema: "sp",
                table: "SP_Client",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SP_Client_LocationId",
                schema: "sp",
                table: "SP_Client");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Client_LocationId",
                schema: "sp",
                table: "SP_Client",
                column: "LocationId",
                unique: true);
        }
    }
}
