using Renda.Infraestrutura.Util;
using Renda.Servico.Containers;
using Renda.Servico.Contratos;
using System;
using System.Windows.Forms;

namespace Renda.Tela.ViewModels
{
    public class ControladorLogin
    {
        private IServicoDeUsuario _servicoUsuario;

        private ResultadoValidacao _resultadoServico;

        private frmLogin _tela;

        public ControladorLogin(frmLogin tela)
        {
            _tela = tela;
            _servicoUsuario = new UsuarioContainer().ObtenhaServicoUsuario();
        }

        public bool LogueUsuario()
        {
            try
            {
                _tela.CarregueDadosTela();
                _resultadoServico = _servicoUsuario.ConfirmarLogin(_tela.Usuario, _tela.Senha);

                if (_resultadoServico.Sucesso)
                {
                    return true;
                } else
                {
                    new frmValidacoes(_resultadoServico).MostreInconsistencias();
                }

            } catch (MyException e)
            {
                new frmExcecao(e).TrateExcecao();

            }
            return false;
        }


    }
}
