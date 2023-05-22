using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_10
{
    
    public class GenerateNumbers
    {
        
        public int doubleCounter;
        public int singleCounter;

        public void GenerateRandomNumber()
        {
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int number = random.Next(1, 101);
                if (number % 2 == 0)
                {
                    doubleCounter++;
                }
                else
                {
                    singleCounter++;
                }               
            }
        }

        
        public async Task GenerateRandomAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Run(() => GenerateRandomNumber());
            }
            Console.WriteLine($"Кiлькiсть парних чисел: {doubleCounter}\nКiлькiсть непарних чисел: {singleCounter}");
             
        }    

    }
}
