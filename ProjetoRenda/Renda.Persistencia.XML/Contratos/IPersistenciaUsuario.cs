using Renda.Infraestrutura.Contratos;
using Renda.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Persistencia.XML.Contratos
{
    public interface IPersistenciaUsuario : IPersistencia<UsuarioObj>
    {
        UsuarioObj ObtenhaUsuarioPorEmail(string email);

        UsuarioObj ObtenhaUsuarioPorLogin(string login);

    }
}
