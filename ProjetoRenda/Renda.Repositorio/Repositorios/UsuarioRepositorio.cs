using Renda.Infraestrutura.Contratos;
using Renda.Negocio.Dominio;
using Renda.Repositorio.Repositorios.Contratos;
using System;

namespace Renda.Repositorio.Repositorios
{
    public class UsuarioRepositorio : IRepositorioUsuario
    {
        private IPersistencia<Usuario> _persistenciaUsuario;

        public UsuarioRepositorio()
        {
            _persistenciaUsuario.Carregar();
        }

        public void InsiraUsuario(Usuario usuario)
        {
            _persistenciaUsuario.Inserir(usuario);
        }

        public void RemovaUsuario(int id)
        {
            _persistenciaUsuario.Remover(id);
        }

        public void AtualizeUsuario(Usuario usuario)
        {
            _persistenciaUsuario.Atualizar(usuario);
        }

        public Usuario ObtenhaUsuarioPorId(int id)
        {
           return _persistenciaUsuario.ObtenhaPorId(id);
        }

        public Boolean ExisteComMesmoId(int id)
        {
            return _persistenciaUsuario.ExisteComMesmoId(id);
        }

        public void Dispose()
        {
            _persistenciaUsuario.Carregar();
            _persistenciaUsuario = null;
        }
    }
}
