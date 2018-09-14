using Renda.Infraestrutura.Util;
using Renda.Servico.Servicos;
using Renda.Servico.Validacao;
using Renda.Tela.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renda.Tela
{
    public partial class frmLogin : Form
    {
        public string Usuario;

        public string Senha;

        private ControladorLogin _controladorLogin;

        public frmLogin()
        {
            InitializeComponent();
            _controladorLogin = new ControladorLogin(this);
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            _controladorLogin.LogueUsuario();
        }

        public void CarregueDadosTela()
        {
            Usuario = txbUsuario.Text;
            Senha = txbSenha.Text;
        }
    }
}
