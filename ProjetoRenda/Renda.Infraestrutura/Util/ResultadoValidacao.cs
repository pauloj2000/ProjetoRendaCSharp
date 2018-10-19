using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Infraestrutura.Util
{
    public class ResultadoValidacao 
    {
        private const string MENSAGEM_PADRAO_VALIDACAO = "As seguintes inconsistências foram encontradas:";

        public ResultadoValidacao()
        {
            _listaErros = new List<string>();
            Sucesso = true;
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

        public string ObtenhaErros()
        {
            string mensagemErro;

            mensagemErro = "";
            _listaErros.ForEach(x =>
           {
               mensagemErro = Environment.NewLine + x + mensagemErro;
           });

            return MENSAGEM_PADRAO_VALIDACAO + mensagemErro;
        }
    }
}
