using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Tienda_TP.Migrations
{
    /// <inheritdoc />
    public partial class Segundo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Productos_IdProducto",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_IdProducto",
                table: "Ventas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha",
                table: "Ventas",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<int>(
                name: "ProdId",
                table: "Ventas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Productos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,10)");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ProdId",
                table: "Ventas",
                column: "ProdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Productos_ProdId",
                table: "Ventas",
                column: "ProdId",
                principalTable: "Productos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Productos_ProdId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_ProdId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "ProdId",
                table: "Ventas");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha",
                table: "Ventas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "Productos",
                type: "decimal(18,10)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "Clientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_IdProducto",
                table: "Ventas",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Productos_IdProducto",
                table: "Ventas",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
