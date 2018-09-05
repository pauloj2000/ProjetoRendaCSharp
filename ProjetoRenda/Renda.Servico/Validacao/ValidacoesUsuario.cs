using Renda.Infraestrutura.Contratos.Validacao;
using Renda.Infraestrutura.Global;
using Renda.Infraestrutura.Util;
using Renda.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Servico.Validacao
{
    public class ValidacoesUsuario
    {
        private ResultadoValidacao _resultadoValidacao;

        public ValidacoesUsuario(ResultadoValidacao resultadoValidacao)
        {
            _resultadoValidacao = resultadoValidacao;
        }

        public ResultadoValidacao ValidaExclusaoContaLogada(UsuarioObj usuario)
        {
            if (usuario.Login == ConfigGeral.UsuarioLogado)
            {
                _resultadoValidacao.AdicionaMensagemErro("Não é possível excluir a conta que se está logado");
            }

            return _resultadoValidacao;

        }
    }
}
