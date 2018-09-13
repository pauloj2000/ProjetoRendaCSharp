using Renda.Infraestrutura.Util;
using Renda.Negocio.Validacao;
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
        private LoginViewModel _loginViewModel;

        public frmLogin()
        {
            InitializeComponent();
            ///_loginViewModel = new LoginViewModel(new ServicoDeUsuario(new ValidadorUsuario(), new RepositorioUsuario()));
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

        }
    }
}
