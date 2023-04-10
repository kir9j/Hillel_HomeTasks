using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();

            var ram1 = new Ram("HyperX", 8);
            var ram2 = new Ram("Samsung", 16);
            var ram3 = new Ram("Micron", 4);

            var harddrive1 = new HardDrive("Toshiba", 128);
            var harddrive2 = new HardDrive("Seagate", 256);

            var cpu = new Cpu("Intel", 13900);

            computer.AddDevice(ram1);
            computer.AddDevice(ram2);
            computer.AddDevice(ram3);

            computer.AddDevice(harddrive1);
            computer.AddDevice(harddrive2);

            computer.AddDevice(cpu);
            
        }
    }
}
