using Renda.Infraestrutura.Contratos;
using Renda.Infraestrutura.Enums;
using Renda.Negocio.Dominio;
using Renda.Persistencia.XML;
using Renda.Repositorio.Repositorios.Contratos;
using System;

namespace Renda.Repositorio.Repositorios
{
    public class UsuarioRepositorio : IRepositorioUsuario
    {
        private IPersistencia<UsuarioObj> _persistenciaUsuario;

        public UsuarioRepositorio(EnumTipoPersistencia tipoPersistencia)
        {
            switch(tipoPersistencia)
            {
                case EnumTipoPersistencia.XML:
                    _persistenciaUsuario = new UsuarioXML();
                    break;
            }
        }

        public void InsiraUsuario(UsuarioObj usuario)
        {
            _persistenciaUsuario.Inserir(usuario);
        }

        public void RemovaUsuario(int id)
        {
            _persistenciaUsuario.Remover(id);
        }

        public void AtualizeUsuario(UsuarioObj usuario)
        {
            _persistenciaUsuario.Atualizar(usuario);
        }

        public UsuarioObj ObtenhaUsuarioPorId(int id)
        {
           return _persistenciaUsuario.ObtenhaPorId(id);
        }

        public Boolean ExisteUsuarioComMesmoId(int id)
        {
            return _persistenciaUsuario.ExisteComMesmoId(id);
        }

        public void Dispose()
        {
            _persistenciaUsuario.Dispose();
            _persistenciaUsuario = null;
        }
    }
}
