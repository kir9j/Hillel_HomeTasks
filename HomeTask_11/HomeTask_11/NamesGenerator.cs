using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11
{
    internal class NamesGenerator : INamesGenerator
    {
        private readonly string[] names = { "John", "Jane", "Alice", "Bob" };
        public string GetRandomName()
        {
            Random random = new Random();
            int index = random.Next(0, names.Length);
            return names[index];
        }
    }
}
