using Renda.Infraestrutura.Contratos;
using Renda.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Renda.Persistencia.XML
{
    public class DividaXML : IPersistencia<DividaObj>
    {
        private List<DividaObj> _listaDividas;

        public void Atualizar(DividaObj divida)
        {
            Remover(divida.Id);
            Inserir(divida);
        }

        private void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<DividaObj>));
            FileStream fs = new FileStream("D://Usuarios.xml", FileMode.OpenOrCreate);

            try
            {
                _listaDividas = ser.Deserialize(fs) as List<DividaObj>;
            }
            catch (InvalidOperationException ex)
            {
                ser.Serialize(fs, _listaDividas);
            }
            finally
            {
                fs.Close();
            }
        }

        public void Dispose()
        {
            Carregar();
            _listaDividas = null;
        }

        public bool ExisteComMesmoId(int id)
        {
            foreach (DividaObj divida in _listaDividas)
            {
                if (divida.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        public void Inserir(DividaObj divida)
        {
            _listaDividas.Add(divida);
        }

        public List<DividaObj> ObtenhaDados()
        {
            return _listaDividas;
        }

        public DividaObj ObtenhaPorId(int id)
        {
            foreach (DividaObj divida in _listaDividas)
            {
                if (divida.Id == id)
                {
                    return divida;
                }
            }

            return null;
        }

        public void Remover(int id)
        {
            _listaDividas.Remove(ObtenhaPorId(id));
        }
    }
}
