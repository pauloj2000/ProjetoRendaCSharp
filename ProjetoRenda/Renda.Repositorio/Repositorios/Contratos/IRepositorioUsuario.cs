using Renda.Infraestrutura.Contratos;
using Renda.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Repositorio.Repositorios.Contratos
{
    public interface IRepositorioUsuario : IRepositorio
    {
        void InsiraUsuario(Usuario usuario);

        void RemovaUsuario(int id);

        void AtualizeUsuario(Usuario usuario);

        Usuario ObtenhaUsuarioPorId(int id);

        Boolean ExisteComMesmoId(int id);

    }
}
