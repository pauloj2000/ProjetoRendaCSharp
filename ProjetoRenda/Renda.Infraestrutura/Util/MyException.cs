using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Infraestrutura.Util
{
    public class MyException : Exception
    {
        public MyException(string nomeClasse, string nomeMetodo)
        {
            NomeClasse = nomeClasse;
            NomeMetodo = nomeMetodo;
        }

        public string NomeClasse;

        public string NomeMetodo;
     
    }
}
