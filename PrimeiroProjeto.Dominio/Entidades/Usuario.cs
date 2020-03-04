using System.Collections.Generic;

namespace PrimeiroProjeto.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public bool Administrador { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if(string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Preencha o seu e-mail!");
            }
        }
    }
}
