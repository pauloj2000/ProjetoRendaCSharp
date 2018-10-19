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
    public partial class frmCadastrar : Form
    {

        public string Usuario;

        public string Email;

        public string Senha;

        public string ConfirmaSenha;

        private ControladorCadastro _controladorLogin;

        public frmCadastrar()
        {
            InitializeComponent();
            _controladorLogin = new ControladorCadastro(this);
        }

        private void txtConfirma_TextChanged(object sender, EventArgs e)
        {

        }
        public void CarregueDadosTela()
        {
            Usuario = txtUsuario.Text;
            Email = txtEmail.Text;
            Senha = txtSenha.Text;
            ConfirmaSenha = txtConfirma.Text;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(_controladorLogin.CadastreUsuario())
            {
                Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }
    }
}
