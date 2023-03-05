using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoSQLite.Migrations
{
    public partial class changelineidproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Machines_MachineId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Lines_LineId",
                table: "Machines");

            migrationBuilder.AlterColumn<int>(
                name: "LineId",
                table: "Machines",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "Devices",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Machines_MachineId",
                table: "Devices",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Lines_LineId",
                table: "Machines",
                column: "LineId",
                principalTable: "Lines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Machines_MachineId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Lines_LineId",
                table: "Machines");

            migrationBuilder.AlterColumn<int>(
                name: "LineId",
                table: "Machines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "Devices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Machines_MachineId",
                table: "Devices",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Lines_LineId",
                table: "Machines",
                column: "LineId",
                principalTable: "Lines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
