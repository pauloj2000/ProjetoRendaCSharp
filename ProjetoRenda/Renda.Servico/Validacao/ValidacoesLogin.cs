
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

        public void AdicioneMensagemUsuarioIncorreto()
        {
            _resultadoValidacao.AdicionaMensagemErro("O login/e-mail informado está incorreto.");
        }

        public void ValideSenhaCorreta(UsuarioObj usuario, string senhaInformada)
        {
            if (usuario.Senha != senhaInformada)
            {
                _resultadoValidacao.AdicionaMensagemErro("A senha está incorreta.");
            }
        }

        public ResultadoValidacao ObtenhaResultado()
        {
            return _resultadoValidacao;
        }
    }
}