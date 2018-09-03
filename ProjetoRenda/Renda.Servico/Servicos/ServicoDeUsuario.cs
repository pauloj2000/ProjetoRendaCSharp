using Renda.Infraestrutura.Global;
using Renda.Infraestrutura.Util;
using Renda.Negocio.Dominio;
using Renda.Negocio.Validacao;
using Renda.Repositorio.Repositorios;
using Renda.Servico.Contratos;
using Renda.Servico.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renda.Servico.Servicos
{
    public class ServicoDeUsuario : IServicoDeUsuario
    {
        public UsuarioObj Cadastrar(UsuarioObj usuario)
        {
            try
            {
                usuario = new ValidadorUsuario().Valide(usuario);

                if (usuario.ResultadoValidacao.Sucesso)
                {
                    using (var repUsuario = new UsuarioRepositorio())
                    {
                        repUsuario.InsiraUsuario(usuario);
                    }
                }

                return usuario;

            } catch (Exception e)
            {
                throw e;
            }
        }

        public UsuarioObj ConfirmarLogin(string loginOuEmail, string senha)
        {
            var validacoesLogin = new ValidacoesLogin();

            try
            {
                using (var repUsuario = new UsuarioRepositorio())
                {
                    var usuario = repUsuario.ObtenhaUsuarioPorEmail(loginOuEmail);

                    if (usuario.Equals(null))
                    {
                        usuario = repUsuario.ObtenhaUsuarioPorLogin(loginOuEmail);
                    }

                    usuario = validacoesLogin.ValideLoginEmailCorreto(usuario);

                    usuario = validacoesLogin.ValideSenhaCorreta(usuario, senha);

                    return usuario;
                }
            } catch (Exception e)
            {
                throw e;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public UsuarioObj ExcluirConta(UsuarioObj usuario)
        {
            var validacoesUsuario = new ValidacoesUsuario();

            try
            {
                validacoesUsuario.ValidaExclusaoContaLogada(usuario);

                using (var repUsuario = new UsuarioRepositorio())
                {
                    repUsuario.RemovaUsuario(usuario.Id);
                }
                return usuario;

            } catch (Exception e)
            {
                throw e;
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

        public bool Logar(string loginOuEmail)
        {
            ConfigGeral.


        }
    }
}
