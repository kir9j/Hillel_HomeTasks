using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_3
{
    internal class Computer : IDisposable
    {
        private IRam[] memorySlots = new IRam[4];
        private IHardDrive[] hardDriveSlots = new IHardDrive[2];
        private ICpu cpuSlot;

        public void AddDevice(IDevice device)
        {

            if (device is IRam)
            {
                for (int i = 0; i < memorySlots.Length; i++)
                {
                    if (memorySlots[i] == null)
                    {
                        memorySlots[i] = (IRam)device;
                        Console.WriteLine("Added memory device to slot {0}", i);
                        return;
                    }
                }
                throw new Exception("No available memory slots");
            }


            if (device is IHardDrive)
            {
                for (int i = 0; i < hardDriveSlots.Length; i++)
                {
                    if (hardDriveSlots[i] == null)
                    {
                        hardDriveSlots[i] = (IHardDrive)device;
                        Console.WriteLine("Added hard drive device to slot {0}", i);
                        return;
                    }
                }
                throw new Exception("No available hard drive slots");
            }


            if (device is ICpu)
            {
                if (cpuSlot == null)
                {
                    cpuSlot = (ICpu)device;
                    Console.WriteLine("Added CPU device");
                }
                else
                {
                    throw new Exception("CPU slot is already occupied");
                }
            }
        }


        public void Dispose()
        {
            for (int i = 0; i < memorySlots.Length; i++)
            {
                if (memorySlots[i] != null)
                {
                    memorySlots[i].Eject();
                }
            }


            for (int i = 0; i < hardDriveSlots.Length; i++)
            {
                if (hardDriveSlots[i] != null)
                {
                    hardDriveSlots[i].Remove();
                }
            }


            if (cpuSlot != null)
            {
                cpuSlot.Unplug();
            }
        }


        ~Computer()
        {
            Dispose();
        }
    }
}
