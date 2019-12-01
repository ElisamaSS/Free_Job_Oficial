using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPilotFreeJob.Migrations
{
    public partial class novasClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServicoId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    ServicoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.ServicoId);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 10, nullable: false),
                    ServicoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                    table.ForeignKey(
                        name: "FK_Categoria_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "ServicoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    ServicoId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => new { x.CategoriaId, x.ServicoId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_Cadastro_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cadastro_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "ServicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cadastro_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CategoriaId",
                table: "Usuario",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ServicoId",
                table: "Usuario",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cadastro_ServicoId",
                table: "Cadastro",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cadastro_UsuarioId",
                table: "Cadastro",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_ServicoId",
                table: "Categoria",
                column: "ServicoId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Categoria_CategoriaId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Servico_ServicoId",
                table: "Usuario");

            migrationBuilder.DropTable(
                name: "Cadastro");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_CategoriaId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_ServicoId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "Usuario");
        }
    }
}
