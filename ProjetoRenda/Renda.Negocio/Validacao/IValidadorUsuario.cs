using Renda.Infraestrutura.Contratos.Validacao;
using Renda.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Negocio.Validacao
{
    public interface IValidadorUsuario : IValidador<UsuarioObj>
    {
    }
}
