using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GCE.Common.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TipoPessoa = table.Column<short>(type: "smallint", nullable: false),
                    Nacional = table.Column<bool>(type: "bit", nullable: false),
                    DataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Situacao = table.Column<bool>(type: "bit", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataConstituicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Porte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaracterizacaoCapital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantidadeQuota = table.Column<double>(type: "float", nullable: false),
                    ValorQuota = table.Column<double>(type: "float", nullable: false),
                    CapitalSocial = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PessoaJuridica");
        }
    }
}
