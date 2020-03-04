using PrimeiroProjeto.Dominio.Contratos;
using PrimeiroProjeto.Dominio.Entidades;
using PrimeiroProjeto.Repositorio.Contexto;
using PrimeiroProjeto.Repositorio.Repositorio;
using System.Linq;

namespace PrimeiroProjeto.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(PrimeiroProjetoContexto primeiroProjetoContexto) : base(primeiroProjetoContexto)
        {
            //a
        }

        public Usuario Obter(string email, string senha)
        {
            return PrimeiroProjetoContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return PrimeiroProjetoContexto.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}
