using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11
{
    public class GreetingsGenerator : IGreetingsGenerator
    {
        public readonly IGreetingsGenerator greetingsGenerator;
        private readonly string[] greetings = { "Hello", "Hi", "Greetings", "Salutations" };

        public GreetingsGenerator(IGreetingsGenerator greetingsGenerator)
        {
            this.greetingsGenerator = greetingsGenerator;
        }
        public string GetRandomGreeting()
        {
            Random random = new Random();
            int index = random.Next(0, greetings.Length);
            return greetings[index];
        }
    }
}
