using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suz.Projetos.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRelacionamentoProjetoCategoriaSubcategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Categorias_CategoriaId",
                table: "Projetos");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Subcategorias_SubcategoriaId",
                table: "Projetos");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Categorias_CategoriaId",
                table: "Projetos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Subcategorias_SubcategoriaId",
                table: "Projetos",
                column: "SubcategoriaId",
                principalTable: "Subcategorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Categorias_CategoriaId",
                table: "Projetos");

            migrationBuilder.DropForeignKey(
                name: "FK_Projetos_Subcategorias_SubcategoriaId",
                table: "Projetos");

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Categorias_CategoriaId",
                table: "Projetos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projetos_Subcategorias_SubcategoriaId",
                table: "Projetos",
                column: "SubcategoriaId",
                principalTable: "Subcategorias",
                principalColumn: "Id");
        }
    }
}
