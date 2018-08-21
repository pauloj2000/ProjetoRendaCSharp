﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renda.Infraestrutura.Contratos;

namespace Renda.Negocio.Dominio
{
    public class Usuario  
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public DateTime MesAtual { get; set; }

    }
}
