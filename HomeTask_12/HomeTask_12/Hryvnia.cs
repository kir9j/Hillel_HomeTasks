using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HomeTask12;

namespace HomeTask12
{
    [Serializable]
    public class Hryvnia : Money
    {
             
        public Hryvnia(string name, int quantity) : base(name, quantity)
        {

        }

        public static void GetInfo(Hryvnia hryvnia)
        {
            Console.WriteLine($"Your currency is {hryvnia.Name}, and quantity {hryvnia.Quantity}");
        }

        public override void Pay()
        {
            Console.WriteLine("Payment completed successfully");
        }

        public override void MakeAPayment(int amount)
        {
            Pay();
            Quantity = Quantity - (amount * 37);
        }

        public static Hryvnia operator +(Hryvnia hryvnia, Hryvnia hryvnia2)
        {
            int quantity = hryvnia.Quantity + hryvnia2.Quantity;
            var hryvnia3 = new Hryvnia("hryvnia", quantity);
            hryvnia3.Quantity = quantity; ;
            return hryvnia3;
        }
    }
}