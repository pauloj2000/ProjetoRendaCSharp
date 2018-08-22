using Renda.Infraestrutura.Contratos;
using Renda.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Renda.Persistencia.XML
{
    public class RendaXML : IPersistencia<RendaObj>
    {
        private List<RendaObj> _listaRendas;

        public RendaXML()
        {
            _listaRendas = new List<RendaObj>();
            Carregar();
        }


        public void Atualizar(RendaObj renda)
        {
            Remover(renda.Id);
            Inserir(renda);
        }

        private void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<RendaObj>));
            FileStream fs = new FileStream("D://Usuarios.xml", FileMode.OpenOrCreate);

            try
            {
                _listaRendas = ser.Deserialize(fs) as List<RendaObj>;
            }
            catch (InvalidOperationException ex)
            {
                ser.Serialize(fs, _listaRendas);
            }
            finally
            {
                fs.Close();
            }
        }

        public void Dispose()
        {
            Carregar();
            _listaRendas = null;
        }

        public bool ExisteComMesmoId(int id)
        {
            foreach (RendaObj renda in _listaRendas)
            {
                if (renda.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        public void Inserir(RendaObj renda)
        {
            _listaRendas.Add(renda);
        }

        public List<RendaObj> ObtenhaDados()
        {
            return _listaRendas;
        }

        public RendaObj ObtenhaPorId(int id)
        {
            foreach (RendaObj renda in _listaRendas)
            {
                if (renda.Id == id)
                {
                    return renda;
                }
            }

            return null;
        }

        public void Remover(int id)
        {
            _listaRendas.Remove(ObtenhaPorId(id));
        }
    }
}
