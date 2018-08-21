using Renda.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Persistencia.EF
{
    public class UsuarioDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
