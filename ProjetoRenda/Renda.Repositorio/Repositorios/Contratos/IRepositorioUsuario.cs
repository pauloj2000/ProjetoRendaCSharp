using Renda.Infraestrutura.Contratos;
using Renda.Negocio.Dominio;
using System;

namespace Renda.Repositorio.Repositorios.Contratos
{
    public interface IRepositorioUsuario : IRepositorio
    {
        void InsiraUsuario(UsuarioObj usuario);

        void RemovaUsuario(int id);

        void AtualizeUsuario(UsuarioObj usuario);

        UsuarioObj ObtenhaUsuarioPorId(int id);

        Boolean ExisteUsuarioComMesmoId(int id);

    }
}
