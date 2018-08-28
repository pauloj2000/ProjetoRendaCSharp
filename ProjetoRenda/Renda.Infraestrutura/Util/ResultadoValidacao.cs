using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Infraestrutura.Util
{
    public class ResultadoValidacao : Exception
    {
        private ResultadoValidacao _instancia;
        private ResultadoValidacao()
        {
            _listaErros = new List<string>();
            Sucesso = true;
        }

        public ResultadoValidacao ObtenhaInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ResultadoValidacao();
            }

            return _instancia;
        }

        private List<string> _listaErros;

        public bool Sucesso { get; private set; }

        public void AdicionaMensagemErro(string mensagem)
        {
            _listaErros.Add(mensagem);
            Sucesso = false;
        }

        public void LimpaErros()
        {
            _listaErros.Clear();
            Sucesso = true;
        }
    }
}
