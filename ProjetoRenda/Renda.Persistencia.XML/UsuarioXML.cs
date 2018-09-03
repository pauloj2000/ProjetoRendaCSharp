using Renda.Infraestrutura.Contratos;
using Renda.Negocio.Dominio;
using Renda.Persistencia.XML.Contratos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Renda.Persistencia.XML
{
    public class UsuarioXML : IPersistenciaUsuario
    {
        public UsuarioXML()
        {
            _listaUsuarios = new List<UsuarioObj>();
            Carregar();
        }

        public List<UsuarioObj> ObtenhaDados()
        {
            return _listaUsuarios;
        }

        private List<UsuarioObj> _listaUsuarios;

        private void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<UsuarioObj>));
            FileStream fs = new FileStream("D://Usuarios.xml", FileMode.OpenOrCreate);

            try
            {
                _listaUsuarios = ser.Deserialize(fs) as List<UsuarioObj>;
            }
            catch (InvalidOperationException ex)
            {
                ser.Serialize(fs, _listaUsuarios);
            }
            finally
            {
                fs.Close();
            }
        }

        public void Inserir(UsuarioObj usuario)
        {
            _listaUsuarios.Add(usuario);

        }

        public Boolean ExisteComMesmoId(int id)
        {
            foreach (UsuarioObj usuario in _listaUsuarios)
            {
                if (usuario.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        public void Atualizar(UsuarioObj usuario)
        {
            Remover(usuario.Id);
            Inserir(usuario);
        }

        public void Remover(int id)
        {
            _listaUsuarios.Remove(ObtenhaPorId(id));
        }

        public UsuarioObj ObtenhaPorId(int id)
        {
            foreach (UsuarioObj usuario in _listaUsuarios)
            {
                if (usuario.Id == id)
                {
                    return usuario;
                }
            }

            return null;
        }

        public UsuarioObj ObtenhaUsuarioPorEmail(string email)
        {
            foreach (UsuarioObj usuario in _listaUsuarios)
            {
                if (usuario.Email == email)
                {
                    return usuario;
                }
            }

            return null;
        }

        public UsuarioObj ObtenhaUsuarioPorLogin(string login)
        {
            foreach (UsuarioObj usuario in _listaUsuarios)
            {
                if (usuario.Login == login)
                {
                    return usuario;
                }
            }

            return null;
        }

        public void Dispose()
        {
            Carregar();
            _listaUsuarios = null;
        }
    }
}
