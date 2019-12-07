using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPilotFreeJob.Migrations
{
    public partial class NovaVersao002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Servico_ServicoId",
                table: "Categoria");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Categoria_CategoriaId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Servico_ServicoId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_CategoriaId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_ServicoId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Categoria_ServicoId",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "Categoria");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Servico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Servico_CategoriaId",
                table: "Servico",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servico_Categoria_CategoriaId",
                table: "Servico",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servico_Categoria_CategoriaId",
                table: "Servico");

            migrationBuilder.DropIndex(
                name: "IX_Servico_CategoriaId",
                table: "Servico");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Servico");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServicoId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServicoId",
                table: "Categoria",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CategoriaId",
                table: "Usuario",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ServicoId",
                table: "Usuario",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_ServicoId",
                table: "Categoria",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Servico_ServicoId",
                table: "Categoria",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "ServicoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Categoria_CategoriaId",
                table: "Usuario",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Servico_ServicoId",
                table: "Usuario",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "ServicoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
