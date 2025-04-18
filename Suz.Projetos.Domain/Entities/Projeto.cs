namespace Suz.Projetos.Domain.Entities
{
    public class Projeto
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string DescricaoProjeto { get; set; }
        public string TituloProjeto { get; set; }

        // Categoria
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;

        // Subcategoria
        public int? SubcategoriaId { get; set; }
        public Subcategoria? Subcategoria { get; set; }
    }
}
