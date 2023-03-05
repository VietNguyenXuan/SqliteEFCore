using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoSQLite.Migrations
{
    public partial class addtableline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LineId",
                table: "Machines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<float>(type: "REAL", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Machines_LineId",
                table: "Machines",
                column: "LineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Lines_LineId",
                table: "Machines",
                column: "LineId",
                principalTable: "Lines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Lines_LineId",
                table: "Machines");

            migrationBuilder.DropTable(
                name: "Lines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_LineId",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "LineId",
                table: "Machines");
        }
    }
}
