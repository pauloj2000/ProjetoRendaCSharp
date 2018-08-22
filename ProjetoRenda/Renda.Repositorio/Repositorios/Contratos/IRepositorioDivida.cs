
using Renda.Infraestrutura.Contratos;
using Renda.Negocio.Dominio;
using System;

namespace Renda.Repositorio.Repositorios.Contratos
{

    public interface IRepositorioDivida : IRepositorio
    {
        void InsiraDivida(DividaObj divida);

        void RemovaDivida(int id);

        void AtualizeDivida(DividaObj divida);

        DividaObj ObtenhaDividaPorId(int id);

        Boolean ExisteDividaComMesmoId(int id);
    }

}