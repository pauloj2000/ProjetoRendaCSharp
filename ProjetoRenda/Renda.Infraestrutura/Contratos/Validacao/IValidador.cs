using Renda.Infraestrutura.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Infraestrutura.Contratos.Validacao
{
    public interface IValidador<T> 
    {
        ResultadoValidacao Valide(T objeto);
    }
}
