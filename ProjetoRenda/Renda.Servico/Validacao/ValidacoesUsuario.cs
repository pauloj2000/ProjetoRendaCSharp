using Renda.Infraestrutura.Global;
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
        public UsuarioObj ValidaExclusaoContaLogada(UsuarioObj usuario)
        {
            if (usuario.Login == ConfigGeral.UsuarioLogado)
            {
                usuario.ResultadoValidacao.AdicionaMensagemErro("Não é possível excluir a conta que se está logado");
            }

            return usuario;

        }
    }
}
