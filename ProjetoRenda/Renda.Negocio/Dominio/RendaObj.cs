using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Negocio.Dominio
{
    public class RendaObj
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public double RendaMensal { get; set; }
        public DateTime MesReferencia { get; set; }
            
    }
}
