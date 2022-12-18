using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JemakEadPro.Migrations
{
    public partial class CusoNullDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Usuario",
                type: "BOOL",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "BOOL",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataVencimentoCRC",
                table: "Curso",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataValidarCRC",
                table: "Curso",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Curso",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Curso",
                type: "BOOL",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "BOOL",
                oldDefaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Usuario",
                type: "BOOL",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "BOOL",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataVencimentoCRC",
                table: "Curso",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataValidarCRC",
                table: "Curso",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Curso",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Curso",
                type: "BOOL",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "BOOL",
                oldNullable: true,
                oldDefaultValue: true);
        }
    }
}
