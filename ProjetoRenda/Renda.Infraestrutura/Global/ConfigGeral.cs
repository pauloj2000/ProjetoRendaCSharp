using Renda.Infraestrutura.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Infraestrutura.Global
{
    public static class ConfigGeral
    {
        public static EnumTipoPersistencia TipoPersistencia { get; private set; }

        public static void DefinaPersistenciaDados(EnumTipoPersistencia tipoPersistencia)
        {
            TipoPersistencia = tipoPersistencia;
        }

        public static string UsuarioLogado { get; private set; }

        public static void LogueUsuario(string usuarioOuEmail)
        {
            UsuarioLogado = usuarioOuEmail;
        }
    }

}
