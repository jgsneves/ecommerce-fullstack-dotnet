using PrimeiroProjeto.Dominio.Contratos;
using PrimeiroProjeto.Dominio.Entidades;
using PrimeiroProjeto.Repositorio.Contexto;
using PrimeiroProjeto.Repositorio.Repositorio;

namespace PrimeiroProjeto.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(PrimeiroProjetoContexto primeiroProjetoContexto) : base(primeiroProjetoContexto)
        {
        }
    }
}
