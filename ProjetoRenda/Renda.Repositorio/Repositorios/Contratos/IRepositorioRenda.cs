
using Renda.Infraestrutura.Contratos;
using Renda.Negocio.Dominio;
using System;

namespace Renda.Repositorio.Repositorios.Contratos
{

    public interface IRepositorioRenda : IRepositorio
    {
        void InsiraRenda(RendaObj renda);

        void RemovaRenda(int id);

        void AtualizeRenda(RendaObj renda);

        RendaObj ObtenhaRendaPorId(int id);

        Boolean ExisteRendaComMesmoId(int id);

    }
}