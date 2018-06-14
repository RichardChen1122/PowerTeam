using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PowerTeam.DAL.Migrations
{
    public partial class CreatePTDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    CloseDate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeliveryType = table.Column<int>(nullable: false),
                    ParentDeliveryGuid = table.Column<Guid>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Deliveries_Deliveries_ParentDeliveryGuid",
                        column: x => x.ParentDeliveryGuid,
                        principalTable: "Deliveries",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    RoleType = table.Column<int>(nullable: false),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    Alias = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Guid);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeliveryGuid = table.Column<Guid>(nullable: true),
                    ItemType = table.Column<int>(nullable: false),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    User = table.Column<Guid>(nullable: true),
                    UserGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Items_Deliveries_DeliveryGuid",
                        column: x => x.DeliveryGuid,
                        principalTable: "Deliveries",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Users_User",
                        column: x => x.User,
                        principalTable: "Users",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SharedItems",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ItemType = table.Column<int>(nullable: false),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    User = table.Column<Guid>(nullable: false),
                    UserGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedItems", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_SharedItems_Users_User",
                        column: x => x.User,
                        principalTable: "Users",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHours",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeliveryId = table.Column<Guid>(nullable: false),
                    LogDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHours", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_WorkHours_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkHours_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ItemGuid = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_Users_Items_ItemGuid",
                        column: x => x.ItemGuid,
                        principalTable: "Items",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryShareditems",
                columns: table => new
                {
                    DeliveryId = table.Column<Guid>(nullable: false),
                    SharedItemId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryShareditems", x => new { x.DeliveryId, x.SharedItemId });
                    table.ForeignKey(
                        name: "FK_DeliveryShareditems_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryShareditems_SharedItems_SharedItemId",
                        column: x => x.SharedItemId,
                        principalTable: "SharedItems",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryUsers",
                columns: table => new
                {
                    DeliveryId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryUsers", x => new { x.DeliveryId, x.UserId });
                    table.ForeignKey(
                        name: "FK_DeliveryUsers_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeliveryUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_ParentDeliveryGuid",
                table: "Deliveries",
                column: "ParentDeliveryGuid");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryShareditems_SharedItemId",
                table: "DeliveryShareditems",
                column: "SharedItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryUsers_UserId",
                table: "DeliveryUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_DeliveryGuid",
                table: "Items",
                column: "DeliveryGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Items_User",
                table: "Items",
                column: "User");

            migrationBuilder.CreateIndex(
                name: "IX_SharedItems_User",
                table: "SharedItems",
                column: "User");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ItemGuid",
                table: "Users",
                column: "ItemGuid");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHours_DeliveryId",
                table: "WorkHours",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHours_UserId",
                table: "WorkHours",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryShareditems");

            migrationBuilder.DropTable(
                name: "DeliveryUsers");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "WorkHours");

            migrationBuilder.DropTable(
                name: "SharedItems");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
