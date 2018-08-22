using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Negocio.Dominio
{
    public class DividaObj
    {
        public int Id { get; set; }

        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public DateTime DataPagamento { get; set; }

        public string Recebedor { get; set; }

        public double Valor { get; set; }

        public string Observacoes { get; set; }

        public DateTime MesPagamento { get; set; }

    }
}
