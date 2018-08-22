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
    public class RendaRepositorio : IRepositorioRenda
    {
        private IPersistencia<RendaObj> _persistenciaRenda;

        public RendaRepositorio(EnumTipoPersistencia tipoPersistencia)
        {
            switch (tipoPersistencia)
            {
                case EnumTipoPersistencia.XML:
                    _persistenciaRenda = new RendaXML();
                    break;
            }
        }
        public void AtualizeRenda(RendaObj renda)
        {
            _persistenciaRenda.Atualizar(renda);
        }

        public void Dispose()
        {
            _persistenciaRenda.Dispose();
            _persistenciaRenda = null;
        }

        public bool ExisteRendaComMesmoId(int id)
        {
            return _persistenciaRenda.ExisteComMesmoId(id);
        }

        public void InsiraRenda(RendaObj renda)
        {
            _persistenciaRenda.Inserir(renda);
        }

        public RendaObj ObtenhaRendaPorId(int id)
        {
            return _persistenciaRenda.ObtenhaPorId(id);
        }

        public void RemovaRenda(int id)
        {
            _persistenciaRenda.Remover(id);
        }
    }
}
