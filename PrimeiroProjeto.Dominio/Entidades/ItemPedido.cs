namespace PrimeiroProjeto.Dominio.Entidades
{
    public class ItemPedido :  Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (Quantidade < 1)
            {
                AdicionarCritica("Escolha ao menos uma unidade de produto");
            }
        }
    }
}
