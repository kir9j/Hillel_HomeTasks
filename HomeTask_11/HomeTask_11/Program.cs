using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace HomeTask_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var module = new RandomMessageBuilderModule();

            StandardKernel kernel = new StandardKernel(module);
            var randomMessage = kernel.Get<IRandomMessageBuilder>();

            randomMessage.AddDateTime(false);
            randomMessage.AddGreeting();
            randomMessage.AddName();

            string result = randomMessage.Result();
            Console.WriteLine(result);

        }
    }
}
