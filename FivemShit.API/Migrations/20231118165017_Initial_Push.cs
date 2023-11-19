using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FivemShit.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Push : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    MemberShipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MemberShipPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MembershipDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.MemberShipId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Script",
                columns: table => new
                {
                    ScriptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScriptName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ScriptPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ScriptDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Script", x => x.ScriptId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscordUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FivemUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ScriptsPurchased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMember = table.Column<bool>(type: "bit", nullable: false),
                    IsWhiteListed = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsBanned = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Memberships",
                        column: x => x.MemberId,
                        principalTable: "Membership",
                        principalColumn: "MemberShipId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Users_Roles",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MemberShipId = table.Column<int>(type: "int", nullable: true),
                    ScriptId = table.Column<int>(type: "int", nullable: true),
                    ScriptQuantity = table.Column<int>(type: "int", nullable: true),
                    ScriptsTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MemberShipPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_Membership",
                        column: x => x.MemberShipId,
                        principalTable: "Membership",
                        principalColumn: "MemberShipId");
                    table.ForeignKey(
                        name: "FK_Carts_Scripts",
                        column: x => x.ScriptId,
                        principalTable: "Script",
                        principalColumn: "ScriptId");
                    table.ForeignKey(
                        name: "FK_Carts_Users",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Users",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MemberShipId = table.Column<int>(type: "int", nullable: true),
                    ScriptId = table.Column<int>(type: "int", nullable: true),
                    ScriptQuantity = table.Column<int>(type: "int", nullable: true),
                    ScriptsTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MemberShipPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Membership",
                        column: x => x.MemberShipId,
                        principalTable: "Membership",
                        principalColumn: "MemberShipId");
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Scripts",
                        column: x => x.ScriptId,
                        principalTable: "Script",
                        principalColumn: "ScriptId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CartId_IsActive",
                table: "Cart",
                columns: new[] { "CartId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CartId_MemberShipId_IsActive",
                table: "Cart",
                columns: new[] { "CartId", "MemberShipId", "IsActive" },
                unique: true,
                filter: "[MemberShipId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CartId_ScriptId_IsActive",
                table: "Cart",
                columns: new[] { "CartId", "ScriptId", "IsActive" },
                unique: true,
                filter: "[ScriptId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CartId_UserId_IsActive",
                table: "Cart",
                columns: new[] { "CartId", "UserId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_MemberShipId",
                table: "Cart",
                column: "MemberShipId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ScriptId",
                table: "Cart",
                column: "ScriptId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Membership_MemberShipId_IsActive",
                table: "Membership",
                columns: new[] { "MemberShipId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderId_IsActive",
                table: "Order",
                columns: new[] { "OrderId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderId_UserId_IsActive",
                table: "Order",
                columns: new[] { "OrderId", "UserId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_MemberShipId",
                table: "OrderDetail",
                column: "MemberShipId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderDetailsId_IsActive",
                table: "OrderDetail",
                columns: new[] { "OrderDetailsId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderDetailsId_MemberShipId_IsActive",
                table: "OrderDetail",
                columns: new[] { "OrderDetailsId", "MemberShipId", "IsActive" },
                unique: true,
                filter: "[MemberShipId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderDetailsId_OrderId_IsActive",
                table: "OrderDetail",
                columns: new[] { "OrderDetailsId", "OrderId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderDetailsId_ScriptId_IsActive",
                table: "OrderDetail",
                columns: new[] { "OrderDetailsId", "ScriptId", "IsActive" },
                unique: true,
                filter: "[ScriptId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ScriptId",
                table: "OrderDetail",
                column: "ScriptId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleId_IsActive",
                table: "Role",
                columns: new[] { "RoleId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Script_ScriptId_IsActive",
                table: "Script",
                columns: new[] { "ScriptId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_MemberId",
                table: "User",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId_IsActive",
                table: "User",
                columns: new[] { "UserId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId_MemberId_IsActive",
                table: "User",
                columns: new[] { "UserId", "MemberId", "IsActive" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId_RoleId_IsActive",
                table: "User",
                columns: new[] { "UserId", "RoleId", "IsActive" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Script");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Membership");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
