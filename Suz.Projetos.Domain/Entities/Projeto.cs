namespace Suz.Projetos.Domain.Entities
{
    public class Projeto
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }

        public int? AutorId { get; set; }
        public Pessoa? Autor { get; set; }
        
        // Categoria
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;

        // Subcategoria
        public int? SubcategoriaId { get; set; }
        public Subcategoria? Subcategoria { get; set; }
    }
}
