using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedPlansupdatesAndPaymentsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "BillingCycle",
                schema: "sp",
                table: "SP_Plan",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "sp",
                table: "SP_Plan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                schema: "sp",
                table: "SP_Plan",
                type: "decimal(19,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<byte>(
                name: "IsActive",
                schema: "sp",
                table: "SP_Plan",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "SP_Payment",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    PaymentMethod = table.Column<byte>(type: "tinyint", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    Currency = table.Column<byte>(type: "tinyint", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_Payment_SP_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_Payment_UserId",
                schema: "sp",
                table: "SP_Payment",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SP_Payment",
                schema: "sp");

            migrationBuilder.DropColumn(
                name: "BillingCycle",
                schema: "sp",
                table: "SP_Plan");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "sp",
                table: "SP_Plan");

            migrationBuilder.DropColumn(
                name: "Discount",
                schema: "sp",
                table: "SP_Plan");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "sp",
                table: "SP_Plan");
        }
    }
}
