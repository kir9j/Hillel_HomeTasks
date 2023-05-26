using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask_12;
using HomeTask12;

namespace HomeTask2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hryvnia obj = new Hryvnia("Hryvnia", 10);
            HryvniaProxyXml proxy = new HryvniaProxyXml(obj);
            #region XML Serialize            
            //var xmlSerialize = new XMLSerializer();
            //var data = xmlSerialize.Serialize(proxy);
            //Console.WriteLine($"{data}\n");

            //var xmlDeserialize = xmlSerialize.Deserialize(data);
            //Console.WriteLine($"{xmlDeserialize.Name}, {xmlDeserialize.Quantity}");
            #endregion

            #region JSON Serialize
            JsonSerializer jsonSerializer = new JsonSerializer();

            var jsonSerialize = jsonSerializer.Serialize(proxy);
            Console.WriteLine($"{jsonSerialize}\n");

            var jsonDeSerialize = jsonSerializer.Deserialize(jsonSerialize);
            Console.WriteLine($"{jsonDeSerialize.Name}, {jsonDeSerialize.Quantity}");
            #endregion

           
        }
    }
}