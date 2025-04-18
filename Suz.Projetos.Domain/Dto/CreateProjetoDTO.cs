namespace Suz.Projetos.Domain.Dto
{
    public class CreateProjetoDTO
    {
        public string TituloProjeto { get; set; }
        public string DescricaoProjeto { get; set; }
        public int CategoriaId { get; set; }
        public int? SubcategoriaId { get; set; }
    }
}