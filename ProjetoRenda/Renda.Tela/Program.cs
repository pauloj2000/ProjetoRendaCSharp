using Renda.Infraestrutura.Enums;
using Renda.Infraestrutura.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renda.Tela
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigGeral.DefinaPersistenciaDados(EnumTipoPersistencia.XML);
            Application.Run(new frmLogin());
        }
    }
}
