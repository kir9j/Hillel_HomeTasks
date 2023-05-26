using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HomeTask12
{
    [Serializable]
    public abstract class Money
    {
        [XmlAttribute("Name")]
        public string Name { get; }

        [XmlElement("Quantity")]
        public int Quantity { get; set; }

        public Money(string name, int quantity)

        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity));
            }

            Name = name;
            Quantity = quantity;
        }

        
        public abstract void Pay();

        public virtual void MakeAPayment(int amount)
        {
            Quantity = Quantity - amount;
        }


    }
}