using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_3
{
    internal class Ram : IRam
    {
        public string name { get; set; }
        public int performance { get; set; }


        public Ram(string name, int performance)
        {
            this.name = name;
            this.performance = performance;
        }


        public void Eject()
        {
            Console.WriteLine($"The RAM {name} with {performance} was ejected");
        }


        public void Connected()
        {
            Console.WriteLine($"The CPU {name} with {performance} connected");
        }
     
    }
}
