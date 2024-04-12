using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sp");

            migrationBuilder.CreateTable(
                name: "SP_Permission",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP_Role",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP_RolePermission",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_RolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_RolePermission_SP_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalSchema: "sp",
                        principalTable: "SP_Permission",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP_RolePermission_SP_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "sp",
                        principalTable: "SP_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SP_User",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccessLevel = table.Column<byte>(type: "tinyint", nullable: false),
                    AccessType = table.Column<byte>(type: "tinyint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    AdminLoginDate = table.Column<DateTime>(type: "datetime2(3)", nullable: true),
                    AccessGlobalSettings = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_User_SP_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "sp",
                        principalTable: "SP_Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP_EntityLog",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    Entity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimaryKey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Category = table.Column<byte>(type: "tinyint", nullable: false),
                    ChangeType = table.Column<byte>(type: "tinyint", nullable: false),
                    ChangeTrigger = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ChangeReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OldData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Changes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActiveUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LoggedInUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LoggedInUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_EntityLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_EntityLog_SP_User_ActiveUserId",
                        column: x => x.ActiveUserId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP_EntityLog_SP_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP_ErrorLog",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActiveUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActiveUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LoggedInUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoggedInUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_ErrorLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_ErrorLog_SP_User_ActiveUserId",
                        column: x => x.ActiveUserId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP_ErrorLog_SP_User_LoggedInUserId",
                        column: x => x.LoggedInUserId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP_LoginLog",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_LoginLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_LoginLog_SP_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP_UserPermission",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_UserPermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_UserPermission_SP_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalSchema: "sp",
                        principalTable: "SP_Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP_UserPermission_SP_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_User",
                columns: new[] { "Id", "AccessGlobalSettings", "AccessLevel", "AccessType", "AdminLoginDate", "DateCreated", "DateModified", "Email", "FirstName", "IsActive", "LastName", "Phone", "RoleId" },
                values: new object[,]
                {
                    { new Guid("17ff54a6-9d9a-45dc-95ea-10b68b9e6378"), false, (byte)0, (byte)0, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "sam@none.com", "Sam", true, "Admin", null, null },
                    { new Guid("4315515f-9932-49b7-a01d-7261047ed1c9"), false, (byte)1, (byte)1, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "dorcis@none.com", "Dorcis", true, "Admin", null, null },
                    { new Guid("dcfaff46-e2c3-4b3d-ba44-dfe86b9dfcd3"), false, (byte)2, (byte)0, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "admin@none.com", "ADM", true, "Admin", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_EntityLog_ActiveUserId",
                schema: "sp",
                table: "SP_EntityLog",
                column: "ActiveUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_EntityLog_UserId",
                schema: "sp",
                table: "SP_EntityLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ErrorLog_ActiveUserId",
                schema: "sp",
                table: "SP_ErrorLog",
                column: "ActiveUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ErrorLog_LoggedInUserId",
                schema: "sp",
                table: "SP_ErrorLog",
                column: "LoggedInUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_LoginLog_UserId",
                schema: "sp",
                table: "SP_LoginLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_RolePermission_PermissionId",
                schema: "sp",
                table: "SP_RolePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_RolePermission_RoleId",
                schema: "sp",
                table: "SP_RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_User_Email",
                schema: "sp",
                table: "SP_User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SP_User_RoleId",
                schema: "sp",
                table: "SP_User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_UserPermission_PermissionId",
                schema: "sp",
                table: "SP_UserPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_UserPermission_UserId",
                schema: "sp",
                table: "SP_UserPermission",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SP_EntityLog",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_ErrorLog",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_LoginLog",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_RolePermission",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_UserPermission",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_Permission",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_User",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_Role",
                schema: "sp");
        }
    }
}
