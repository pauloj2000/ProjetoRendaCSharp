
using Renda.Infraestrutura.Util;
using Renda.Negocio.Dominio;

namespace Renda.Servico.Validacao
{
    public class ValidacoesLogin
    {
        public UsuarioObj ValideLoginEmailCorreto(UsuarioObj usuario)
        {
            if (usuario.Equals(null))
            {
                usuario.ResultadoValidacao.AdicionaMensagemErro("O login/e-mail informado está incorreto.");
            }

            return usuario;

        }

        public UsuarioObj ValideSenhaCorreta(UsuarioObj usuario, string senhaInformada)
        { 
            if (usuario.Senha != senhaInformada)
            {
                usuario.ResultadoValidacao.AdicionaMensagemErro("A senha está incorreta.");
            }

            return usuario;
        }

        public UsuarioObj Valide
}

}