using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeTask_8
{ 
    internal class Program
    {
        static int doubleNumbers = 0;
        static int unpairedNumbers = 0;
        static object block = new object(); 
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(GetRandomNumber);
                threads[i].Start();
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine($"Парних чисел: {doubleNumbers}\nНепарних чисел: {unpairedNumbers}");
        }


        public static void GetRandomNumber()
        {
            
            Random random= new Random();
            int randomNumber;

            for (int i = 1; i <= 100; i++)
            {
                randomNumber = random.Next();
                if (randomNumber % 2 == 0)
                {
                    lock (block) { doubleNumbers++; }
                    
                }
                else
                {
                    lock (block) { unpairedNumbers++; }
                }
            }



        }
    }
}
