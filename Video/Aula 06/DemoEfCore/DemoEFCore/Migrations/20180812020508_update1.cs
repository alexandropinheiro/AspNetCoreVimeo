using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCore.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Eventos",
                newName: "EventoId");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Eventos",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventoId",
                table: "Eventos",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Eventos",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);
        }
    }
}
