using Renda.Infraestrutura.Contratos;
using Renda.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Renda.Persistencia.XML
{
    public class UsuarioXML : IPersistencia<Usuario>
    {
        public UsuarioXML()
        {
            _listaUsuarios = new List<Usuario>();
            Carregar();
        }

        public List<Usuario> ObtenhaDados()
        {
            return _listaUsuarios;
        }

        private List<Usuario> _listaUsuarios;

        public void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Usuario>));
            FileStream fs = new FileStream("D://Usuarios.xml", FileMode.OpenOrCreate);

            try
            {
                _listaUsuarios = ser.Deserialize(fs) as List<Usuario>;
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

        public void Inserir(Usuario usuario)
        {
            _listaUsuarios.Add(usuario);

        }

        public Boolean ExisteComMesmoId(int id)
        {
            foreach (Usuario user in _listaUsuarios)
            {
                if (user.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        public void Atualizar(Usuario usuario)
        {
            Remover(usuario.Id);
            Inserir(usuario);
        }

        public void Remover(int id)
        {
            _listaUsuarios.Remove(ObtenhaPorId(id));
        }

        public Usuario ObtenhaPorId(int id)
        {
            foreach (Usuario user in _listaUsuarios)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
