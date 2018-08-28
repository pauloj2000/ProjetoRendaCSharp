using Renda.Infraestrutura.Global;
using Renda.Negocio.Dominio;
using Renda.Negocio.Validacao;
using Renda.Repositorio.Repositorios;
using Renda.Servico.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Servico.Servicos
{
    public class ServicoDeUsuario : IServicoDeUsuario
    {
        public void Cadastrar(UsuarioObj usuario)
        {
            var resultadoValidacao = new ValidadorUsuario().Valide(usuario);

            if (resultadoValidacao.Sucesso)
            {
                using (var repUsuario = new UsuarioRepositorio())
                {
                    repUsuario.InsiraUsuario(usuario);
                }
            } else {
                throw resultadoValidacao;
            }
        }

        public bool ConfirmarLogin(string loginOuEmail, string senha)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ExcluirConta(UsuarioObj usuario)
        {
            using (var repUsuario = new UsuarioRepositorio())
            {
                repUsuario.RemovaUsuario(usuario.Id);
            }
        }

        public bool ExisteUsuarioOuEmail(string loginOuEmail)
        {
            using (var repUsuario = new UsuarioRepositorio())
            {
                var usuario = repUsuario.ObtenhaUsuarioPorLogin(loginOuEmail);
                if (usuario.Equals(null))
                {
                    usuario = repUsuario.ObtenhaUsuarioPorEmail(loginOuEmail);
                }

                return usuario != null;
            }
        }

        public void Logar(string loginOuEmail)
        {
            throw new NotImplementedException();
        }
    }
}
