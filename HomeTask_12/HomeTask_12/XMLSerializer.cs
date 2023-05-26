using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask12;
using System.Xml.Serialization;
using System.Data.SqlTypes;

namespace HomeTask_12
{
    public class XMLSerializer
    {
        private XmlSerializer serializer = new XmlSerializer(typeof(HryvniaProxyXml));

        public string Serialize(HryvniaProxyXml obj)
        {
            var writer = new StringWriter();
            serializer.Serialize(writer, obj);
            var xmlString = writer.ToString();

            return xmlString;
        }

        public HryvniaProxyXml Deserialize(string data)
        {
            var reader = new StringReader(data);
            var deserializeHryvnia = (HryvniaProxyXml)serializer.Deserialize(reader);

            
            return deserializeHryvnia;  
        }
        
    }

    

}
