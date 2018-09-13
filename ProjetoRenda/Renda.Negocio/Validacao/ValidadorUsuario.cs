using Renda.Infraestrutura.Contratos.Validacao;
using Renda.Infraestrutura.Util;
using Renda.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Negocio.Validacao
{
    public class ValidadorUsuario : IValidadorUsuario
    {
        private const string MENSAGEM_CAMPO_OBRIGATORIO = "O campo {0} é de preenchimento obrigatório.";

        private const string MENSAGEM_QUANTIDADE_CARACTERES = "O campo {0} deve ter entre {1} e {2} caracteres.";

        private ResultadoValidacao ApliqueRegrasValidacao(UsuarioObj usuario)
        {
            _resultadoValidacao = new ResultadoValidacao();

            if (usuario.Login == null)
            {
                _resultadoValidacao.AdicionaMensagemErro(ConstruaMensagem(MENSAGEM_CAMPO_OBRIGATORIO, "Login"));
            }

            if (usuario.Nome == null)
            {
                _resultadoValidacao.AdicionaMensagemErro(ConstruaMensagem(MENSAGEM_CAMPO_OBRIGATORIO, "Nome"));
            }

            if (usuario.Senha == null)
            {
                _resultadoValidacao.AdicionaMensagemErro(ConstruaMensagem(MENSAGEM_CAMPO_OBRIGATORIO, "Senha"));
            }

            if (usuario.Email == null)
            {
                _resultadoValidacao.AdicionaMensagemErro(ConstruaMensagem(MENSAGEM_CAMPO_OBRIGATORIO, "Email"));
            }

            if (usuario.MesAtual == null)
            {
                _resultadoValidacao.AdicionaMensagemErro(ConstruaMensagem(MENSAGEM_CAMPO_OBRIGATORIO, "MesAtual"));
            }

            if (usuario.Login.Length < 6 || usuario.Login.Length > 30)
            {
                _resultadoValidacao.AdicionaMensagemErro(ConstruaMensagem(MENSAGEM_QUANTIDADE_CARACTERES, "Login.", 6, 30));
            }

            if (usuario.Nome.Length < 3 || usuario.Nome.Length > 50)
            {
                _resultadoValidacao.AdicionaMensagemErro(ConstruaMensagem(MENSAGEM_QUANTIDADE_CARACTERES, "Nome", 3, 50));
            }

            if (usuario.Senha.Length < 8 || usuario.Senha.Length > 30)
            {
                _resultadoValidacao.AdicionaMensagemErro(ConstruaMensagem(MENSAGEM_QUANTIDADE_CARACTERES, "Senha", 8, 30));
            }

            return _resultadoValidacao;
        }

        private ResultadoValidacao _resultadoValidacao;

        public ValidadorUsuario()
        {
        }

        private ValidadorUsuario _instancia;

        public ResultadoValidacao Valide(UsuarioObj usuario)
        {
            if(_instancia == null)
            {
                _instancia = new ValidadorUsuario();
            }

            _resultadoValidacao = new ResultadoValidacao();

            return _instancia.ApliqueRegrasValidacao(usuario);
        }

        private string ConstruaMensagem(string mensagem, string nomeDoCampo, params object[] args)
        {
            return String.Format(mensagem, nomeDoCampo, args);
        }

    }
}
