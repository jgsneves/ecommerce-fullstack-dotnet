using PrimeiroProjeto.Dominio.Contratos;
using PrimeiroProjeto.Dominio.Entidades;
using PrimeiroProjeto.Repositorio.Contexto;
using PrimeiroProjeto.Repositorio.Repositorio;

namespace PrimeiroProjeto.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(PrimeiroProjetoContexto primeiroProjetoContexto) : base(primeiroProjetoContexto)
        {
        }
    }
}
