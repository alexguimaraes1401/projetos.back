namespace Suz.Projetos.Domain.Entities
{
    public class Projeto
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string DescricaoProjeto { get; set; }
        public string TituloProjeto { get; set; }

        // Categoria
    }
}
