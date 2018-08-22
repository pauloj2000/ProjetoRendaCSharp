using Renda.Infraestrutura.Contratos;
using Renda.Infraestrutura.Enums;
using Renda.Negocio.Dominio;
using Renda.Persistencia.XML;
using Renda.Repositorio.Repositorios.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Repositorio.Repositorios
{
    public class DividaRepositorio : IRepositorioDivida
    {
        private IPersistencia<DividaObj> _persistenciaDivida;

        public DividaRepositorio(EnumTipoPersistencia tipoPersistencia)
        {
            switch (tipoPersistencia)
            {
                case EnumTipoPersistencia.XML:
                    _persistenciaDivida = new DividaXML();
                    break;
            }
        }

        public void AtualizeDivida(DividaObj divida)
        {
            _persistenciaDivida.Atualizar(divida);
        }

        public void Dispose()
        {
            _persistenciaDivida.Dispose();
            _persistenciaDivida = null;
        }

        public bool ExisteDividaComMesmoId(int id)
        {
            return _persistenciaDivida.ExisteComMesmoId(id);
        }

        public void InsiraDivida(DividaObj divida)
        {
            _persistenciaDivida.Inserir(divida);
        }

        public DividaObj ObtenhaDividaPorId(int id)
        {
            return _persistenciaDivida.ObtenhaPorId(id);
        }

        public void RemovaDivida(int id)
        {
            _persistenciaDivida.Remover(id);
        }
    }
}
