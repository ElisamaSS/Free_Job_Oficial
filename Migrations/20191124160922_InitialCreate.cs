using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectPilotFreeJob.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    CPF = table.Column<int>(nullable: false),
                    RG = table.Column<int>(nullable: false),
                    CNH = table.Column<int>(nullable: false),
                    DataDeNascimento = table.Column<DateTime>(nullable: false),
                    Idade = table.Column<int>(nullable: false),
                    Telefone = table.Column<int>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    CEP = table.Column<int>(nullable: false),
                    Cidade = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
