using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suz.Projetos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AlterRenomeiaPropriedades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TituloProjeto",
                table: "Projetos",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "DescricaoProjeto",
                table: "Projetos",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "NomePessoa",
                table: "Pessoas",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Projetos",
                newName: "TituloProjeto");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Projetos",
                newName: "DescricaoProjeto");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Pessoas",
                newName: "NomePessoa");
        }
    }
}
