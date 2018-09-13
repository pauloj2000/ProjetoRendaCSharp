using Renda.Servico.Containers;
using Renda.Servico.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Tela.ViewModels
{
    public class LoginViewModel
    {
        private IServicoDeUsuario _servicoUsuario;

        private ITela _tela;
        public LoginViewModel(ITela tela)
        {
            _tela = tela;
            _servicoUsuario = new UsuarioContainer().ObtenhaServicoUsuario();
        }
    }
}
