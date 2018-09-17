using Renda.Infraestrutura.Util;
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
    public partial class frmExcecao : Form
    {
        private MyException _excecao;

        public frmExcecao(MyException excecao)
        {
            InitializeComponent();
            _excecao = excecao;
        }

        private void frmExcecao_Load(object sender, EventArgs e)
        {

        }

        public void TrateExcecao()
        {
            lblTipo.Text = _excecao.InnerException.ToString();
            lblMetodo.Text = _excecao.NomeMetodo;
            lblClasse.Text = _excecao.NomeClasse;
            rtxbDescricaoErro.Text = _excecao.Message;
        }
        
    }
}
