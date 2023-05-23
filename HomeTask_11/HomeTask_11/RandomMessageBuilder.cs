using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace HomeTask_11
{
    public class RandomMessageBuilder : IRandomMessageBuilder
    {
        public  IDateTimeGenerator dateTimeGenerator;
        public  IGreetingsGenerator greetingsGenerator;
        public  INamesGenerator namesGenerator;
        private StringBuilder result = new StringBuilder();

        public RandomMessageBuilder(IDateTimeGenerator dateTimeGenerator)
        {
            this.dateTimeGenerator = dateTimeGenerator;
            result = new StringBuilder();
        }
        public void AddDateTime(bool isRandom)
        {
            if (isRandom)
                result.Append(dateTimeGenerator.GetRandomDateTіme());
            else
                result.Append(dateTimeGenerator.GetCurrentDateTime());
        }

        public void AddGreeting()
        {
            result.Append(greetingsGenerator.GetRandomGreeting());
        }

        public void AddName()
        {
            result.Append(namesGenerator.GetRandomName());
        }

        public string Result()
        {
            return result.ToString();
        }

        public void PrintResult()
        {
            Console.WriteLine(Result());
        }
    }
}

