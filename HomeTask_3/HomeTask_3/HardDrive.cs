using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_3
{
    internal class HardDrive : IHardDrive
    {
        public string name { get; set; }
        public int performance { get; set; }

        public HardDrive(string name, int performance)
        {
            this.name = name;
            this.performance = performance;
        }

        public void Remove()
        {
            Console.WriteLine($"The hardrive {name} with {performance} was removed");
        }

        public void Connected()
        {
            Console.WriteLine($"The hardrive {name} with {performance} connected");
        }
    }
}
