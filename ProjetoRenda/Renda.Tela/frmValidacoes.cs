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
    public partial class frmValidacoes : Form
    {
        private ResultadoValidacao _resultadoValidacao;

        public frmValidacoes(ResultadoValidacao resultadoValidacao)
        {
            InitializeComponent();
            _resultadoValidacao = resultadoValidacao;
        }

        public void MostreInconsistencias()
        {

        }
    }
}
