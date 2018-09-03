using Renda.Infraestrutura.Util;
using Renda.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Servico.Contratos
{
    public interface IServicoDeUsuario : IDisposable
    {
        UsuarioObj ExisteUsuarioOuEmail(string loginOuEmail);

        UsuarioObj ConfirmarLogin(string loginOuEmail, string senha);

        UsuarioObj Logar(string loginOuEmail);

        UsuarioObj Cadastrar(UsuarioObj usuario);

        UsuarioObj ExcluirConta(UsuarioObj usuario);
    }
}
