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
        bool ExisteUsuarioOuEmail(string loginOuEmail);

        ResultadoValidacao ConfirmarLogin(string loginOuEmail, string senha);

        void Logar(string loginOuEmail);

        ResultadoValidacao Cadastrar(UsuarioObj usuario);

        ResultadoValidacao ExcluirConta(UsuarioObj usuario);
    }
}
