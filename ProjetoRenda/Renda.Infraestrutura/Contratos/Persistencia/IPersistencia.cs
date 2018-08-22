using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Infraestrutura.Contratos
{
    public interface IPersistencia<T> : IDisposable
    {
        void Inserir(T item);

        void Atualizar(T item);

        void Remover(int id);

        Boolean ExisteComMesmoId(int id);

        T ObtenhaPorId(int id);

        List<T> ObtenhaDados();
    }
}
