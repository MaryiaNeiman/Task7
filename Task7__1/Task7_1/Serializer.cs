using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace Task7_1
{
    class Serializer
    {
        private XmlSerializer xs;

        public Serializer()
        {
            xs = new XmlSerializer(typeof(Catalog));
        }

        public  Catalog Deserialize(string path)
        {
            try
            {
                using (Stream reader = new FileStream(path, FileMode.Open))
                {
                    Catalog catalog = (Catalog)xs.Deserialize(reader);
                    return catalog;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public  void Serialize(Catalog obj, string pathToFile)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "http://library.by/catalog");


            using (var writer = new StreamWriter(pathToFile, false, Encoding.UTF8))
            {
                xs.Serialize(writer, obj, ns);
           
            }
        }
    }
}
