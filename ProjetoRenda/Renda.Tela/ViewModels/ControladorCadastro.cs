using Renda.Infraestrutura.Util;
using Renda.Negocio.Dominio;
using Renda.Servico.Containers;
using Renda.Servico.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renda.Tela.ViewModels
{
    public class ControladorCadastro
    {
        private IServicoDeUsuario _servicoUsuario;

        private ResultadoValidacao _resultadoServico;

        private frmCadastrar _tela;
        
        public ControladorCadastro(frmCadastrar tela)
        {
            _tela = tela;
            _servicoUsuario = new UsuarioContainer().ObtenhaServicoUsuario();
        }

        public bool CadastreUsuario()
        {
            try
            {
                _tela.CarregueDadosTela();

                if (!ValidaSenhas())
                {
                    MessageBox.Show("Senhas não conferem");
                    return false;
                }

                var user = new UsuarioObj();

                user.Nome = _tela.Usuario;
                user.Email = _tela.Email;
                user.Senha = _tela.Senha;

                _resultadoServico = _servicoUsuario.Cadastrar(user);

                if (_resultadoServico.Sucesso)
                {
                    return true;
                }
                else
                {
                    new frmValidacoes(_resultadoServico).MostreInconsistencias();
                }
            }
            catch (MyException e)
            {
                new frmExcecao(e).TrateExcecao();
            }
            return false;
        }

        private bool ValidaSenhas()
        {
            if (_tela.Senha == _tela.ConfirmaSenha)
            {
                return true;
            }
            return false;
        }

        //public bool LogueUsuario()
        //{
        //    try
        //    {
        //        _tela.CarregueDadosTela();
        //        _resultadoServico = _servicoUsuario.ConfirmarLogin(_tela.Usuario, _tela.Senha);

        //        if (_resultadoServico.Sucesso)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            new frmValidacoes(_resultadoServico).MostreInconsistencias();
        //        }

        //    }
        //    catch (MyException e)
        //    {
        //        new frmExcecao(e).TrateExcecao();

        //    }
        //    return false;
        //}
    }
}
