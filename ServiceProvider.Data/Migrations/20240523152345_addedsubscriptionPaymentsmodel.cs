using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedsubscriptionPaymentsmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SP_SubscriptionPayments",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(19,4)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_SubscriptionPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_SubscriptionPayments_SP_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalSchema: "sp",
                        principalTable: "SP_Payment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP_SubscriptionPayments_SP_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalSchema: "sp",
                        principalTable: "SP_Subscription",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_SubscriptionPayments_PaymentId",
                schema: "sp",
                table: "SP_SubscriptionPayments",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SP_SubscriptionPayments_SubscriptionId",
                schema: "sp",
                table: "SP_SubscriptionPayments",
                column: "SubscriptionId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SP_SubscriptionPayments",
                schema: "sp");
        }
    }
}
