using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class subscriptionMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SP_Subscription",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    RenewalType = table.Column<byte>(type: "tinyint", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Subscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_Subscription_SP_Plan_PlanId",
                        column: x => x.PlanId,
                        principalSchema: "sp",
                        principalTable: "SP_Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP_Subscription_SP_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_Subscription_PlanId",
                schema: "sp",
                table: "SP_Subscription",
                column: "PlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SP_Subscription_UserId",
                schema: "sp",
                table: "SP_Subscription",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SP_Subscription",
                schema: "sp");
        }
    }
}
