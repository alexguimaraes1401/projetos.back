using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suz.Projetos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRelacionamentoAutor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "Projetos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projetos_AutorId",
                table: "Projetos",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Pessoas_AutorId",
                table: "Projetos",
                column: "AutorId",
                principalTable: "Pessoas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Pessoas_AutorId",
                table: "Projetos");

            migrationBuilder.DropIndex(
                name: "IX_Projetos_AutorId",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "Projetos");
        }
    }
}
