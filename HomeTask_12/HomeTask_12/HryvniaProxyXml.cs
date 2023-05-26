using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using HomeTask12;

namespace HomeTask_12
{
    [Serializable]
    public class HryvniaProxyXml
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public HryvniaProxyXml()
        {
        }

        public HryvniaProxyXml(Hryvnia obj)
        {
            Name = obj.Name;
            Quantity = obj.Quantity;    
        }
      
    }
}
