namespace PrimeiroProjeto.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string NomeArquivo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Adicione um nome para o produto");
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Descrição do produto não informada");
            }

            if (Preco == 0)
            {
                AdicionarCritica("Insira um preço para o produto.");
            }
        }
    }
}
