using Renda.Infraestrutura.Contratos;
using Renda.Infraestrutura.Contratos.Validacao;
using Renda.Infraestrutura.Global;
using Renda.Infraestrutura.Util;
using Renda.Negocio.Dominio;
using Renda.Negocio.Validacao;
using Renda.Repositorio.Repositorios;
using Renda.Repositorio.Repositorios.Contratos;
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
        public ServicoDeUsuario(IValidadorUsuario validador, IRepositorioUsuario repositorio)
        {
            _validadorUsuario = validador;
            _repositorioUsuario = repositorio;
            _resultadoValidacao = new ResultadoValidacao();
        }

        private IValidadorUsuario _validadorUsuario;

        private IRepositorioUsuario _repositorioUsuario;

        private ResultadoValidacao _resultadoValidacao;

        public ResultadoValidacao Cadastrar(UsuarioObj usuario)
        {
            try
            {
                _resultadoValidacao.LimpaErros();

                _resultadoValidacao = _validadorUsuario.Valide(usuario);

                if (_resultadoValidacao.Sucesso)
                {
                        _repositorioUsuario.InsiraUsuario(usuario);
                }

                return _resultadoValidacao;

            } catch (Exception e)
            {
                throw e;
            }
        }

        public ResultadoValidacao ConfirmarLogin(string loginOuEmail, string senha)
        {
            try
            {
                _resultadoValidacao.LimpaErros();

                var validacoesLogin = new ValidacoesLogin(_resultadoValidacao);

                var usuario = _repositorioUsuario.ObtenhaUsuarioPorEmail(loginOuEmail);

                if (usuario.Equals(null))
                {
                    usuario = _repositorioUsuario.ObtenhaUsuarioPorLogin(loginOuEmail);
                }

                _resultadoValidacao = validacoesLogin.ValideLoginEmailCorreto(usuario);
                _resultadoValidacao = validacoesLogin.ValideSenhaCorreta(usuario, senha);

                return _resultadoValidacao;

            } catch (Exception e)
            {
                throw e;
            }
        }

        public void Dispose()
        {
            _repositorioUsuario.Dispose();
            _repositorioUsuario = null;
            _validadorUsuario = null;
            _resultadoValidacao = null;
        }

        public ResultadoValidacao ExcluirConta(UsuarioObj usuario)
        {
            _resultadoValidacao.LimpaErros();

            var validacoesUsuario = new ValidacoesUsuario(_resultadoValidacao);

            try
            {
                _resultadoValidacao = validacoesUsuario.ValidaExclusaoContaLogada(usuario);

                if (!_resultadoValidacao.Sucesso)
                {
                    _repositorioUsuario.RemovaUsuario(usuario.Id);
                }

                return _resultadoValidacao;

            } catch (Exception e)
            {
                throw e;
            }
        }

        public bool ExisteUsuarioOuEmail(string loginOuEmail)
        {
                var usuario = _repositorioUsuario.ObtenhaUsuarioPorLogin(loginOuEmail);

                if (usuario.Equals(null))
                {
                    usuario = _repositorioUsuario.ObtenhaUsuarioPorEmail(loginOuEmail);
                }

                return usuario != null;
        }

        public void Logar(string loginOuEmail)
        {
            ConfigGeral.LogueUsuario(loginOuEmail);
        }
    }
}
