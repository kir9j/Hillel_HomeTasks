using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_3
{
    internal class Cpu : ICpu
    {
        public string name { get; set; }
        public int performance { get; set; }

        public Cpu(string name, int performance)
        {
            this.name = name;
            this.performance = performance;
        }

        public void Unplug()
        {
            Console.WriteLine($"The CPU {name} with {performance} was unpluged");
        }

        public void Connected()
        {
            Console.WriteLine($"The CPU {name} with {performance} connected");
        }
    }
}
