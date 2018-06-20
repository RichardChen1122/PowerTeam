using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PowerTeam.DAL.Migrations
{
    public partial class _20180620 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryTags",
                table: "DeliveryTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryShareditems",
                table: "DeliveryShareditems");

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "UserRoles",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "UserRoles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "UserRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "UserRoles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "UserRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "DeliveryTags",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "DeliveryTags",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "DeliveryTags",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "DeliveryTags",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "DeliveryTags",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                table: "DeliveryShareditems",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "DeliveryShareditems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "DeliveryShareditems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "DeliveryShareditems",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "DeliveryShareditems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryTags",
                table: "DeliveryTags",
                column: "Guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryShareditems",
                table: "DeliveryShareditems",
                column: "Guid");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryTags_DeliveryId",
                table: "DeliveryTags",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryShareditems_DeliveryId",
                table: "DeliveryShareditems",
                column: "DeliveryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryTags",
                table: "DeliveryTags");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryTags_DeliveryId",
                table: "DeliveryTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryShareditems",
                table: "DeliveryShareditems");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryShareditems_DeliveryId",
                table: "DeliveryShareditems");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "DeliveryTags");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "DeliveryTags");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "DeliveryTags");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "DeliveryTags");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "DeliveryTags");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "DeliveryShareditems");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "DeliveryShareditems");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "DeliveryShareditems");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "DeliveryShareditems");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "DeliveryShareditems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryTags",
                table: "DeliveryTags",
                columns: new[] { "DeliveryId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryShareditems",
                table: "DeliveryShareditems",
                columns: new[] { "DeliveryId", "SharedItemId" });
        }
    }
}
