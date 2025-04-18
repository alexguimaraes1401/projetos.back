namespace Suz.Projetos.Domain.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public ICollection<Subcategoria> Subcategorias { get; set; } = new List<Subcategoria>();
    }
}