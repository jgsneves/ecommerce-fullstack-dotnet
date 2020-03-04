using PrimeiroProjeto.Dominio.Contratos;
using PrimeiroProjeto.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace PrimeiroProjeto.Repositorio.Repositorio
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly PrimeiroProjetoContexto PrimeiroProjetoContexto;
        public BaseRepositorio(PrimeiroProjetoContexto primeiroProjetoContexto)
        {
            PrimeiroProjetoContexto = primeiroProjetoContexto;
        }
        public void Adicionar(TEntity entity)
        {
            PrimeiroProjetoContexto.Set<TEntity>().Add(entity);
            PrimeiroProjetoContexto.SaveChanges();
        }
        public void Atualizar(TEntity entity)
        {
            PrimeiroProjetoContexto.Set<TEntity>().Update(entity);
            PrimeiroProjetoContexto.SaveChanges();
        }
        public TEntity ObterPorId(int id)
        {
            return PrimeiroProjetoContexto.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> ObterTodos()
        {
            return PrimeiroProjetoContexto.Set<TEntity>().ToList();
        }
        public void Remover(TEntity entity)
        {
            PrimeiroProjetoContexto.Remove(entity);
            PrimeiroProjetoContexto.SaveChanges();
        }
        public void Dispose()
        {
            PrimeiroProjetoContexto.Dispose();
        }
    }
}
