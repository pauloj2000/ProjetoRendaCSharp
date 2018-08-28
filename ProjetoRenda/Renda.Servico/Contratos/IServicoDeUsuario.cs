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
        Boolean ExisteUsuarioOuEmail(string loginOuEmail);

        Boolean ConfirmarLogin(string loginOuEmail, string senha);

        void Logar(string loginOuEmail);

        void Cadastrar(UsuarioObj usuario);

        void ExcluirConta(UsuarioObj usuario);
    }
}
