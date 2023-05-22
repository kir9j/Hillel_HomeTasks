using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeTask_10
{
    internal class Program
    {
        public static async Task Main()
        {
            GenerateNumbers generator = new GenerateNumbers();
            await generator.GenerateRandomAsync();
        }
    }
}
