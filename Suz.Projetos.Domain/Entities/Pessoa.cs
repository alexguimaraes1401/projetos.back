namespace Suz.Projetos.Domain.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }

        public ICollection<Projeto>? Projetos { get; set; }
    }
}
