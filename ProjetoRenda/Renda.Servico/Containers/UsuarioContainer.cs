using Renda.Negocio.Validacao;
using Renda.Repositorio.Repositorios;
using Renda.Servico.Contratos;
using Renda.Servico.Servicos;

namespace Renda.Servico.Containers
{
    public class UsuarioContainer
    {
        public IServicoDeUsuario ObtenhaServicoUsuario()
        {
            return new ServicoDeUsuario(new ValidadorUsuario(), new UsuarioRepositorio());
        }
        
    }
}
