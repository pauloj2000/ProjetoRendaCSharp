
using Renda.Infraestrutura.Contratos.Validacao;
using Renda.Infraestrutura.Util;
using Renda.Negocio.Dominio;

namespace Renda.Servico.Validacao
{
    public class ValidacoesLogin
    {
        private ResultadoValidacao _resultadoValidacao;
        public ValidacoesLogin(ResultadoValidacao resultadoValidacao)
        {
            _resultadoValidacao = resultadoValidacao;
        }

        public ResultadoValidacao ValideLoginEmailCorreto(UsuarioObj usuario)
        {
            if (usuario.Equals(null))
            {
                _resultadoValidacao.AdicionaMensagemErro("O login/e-mail informado está incorreto.");
            }

            return _resultadoValidacao;
        }

        public ResultadoValidacao ValideSenhaCorreta(UsuarioObj usuario, string senhaInformada)
        {
            if (usuario.Senha != senhaInformada)
            {
                _resultadoValidacao.AdicionaMensagemErro("A senha está incorreta.");
            }

            return _resultadoValidacao;
        }
    }
}