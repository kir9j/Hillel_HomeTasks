using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeTask_9
{
    public class Params
    {
        public int from;
        public int to;
    }

    internal class Program
    {
        public static object block = new object();
        public static int sumOfNumbers = 0;
        public static int[] rangeNumbers = new int[100000];
        public static ManualResetEvent resetEvent = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            GetArrRangeNumbers();

            Thread thread1 = new Thread(new ParameterizedThreadStart(GetSum));
            Params par1 = new Params() { from = 1, to = 25000 };
            thread1.Start(par1);
            

            Thread thread2 = new Thread(new ParameterizedThreadStart(GetSum));
            Params par2 = new Params() { from = 25000, to = 50000 };
            thread2.Start(par2);
            
            Thread thread3 = new Thread(new ParameterizedThreadStart(GetSum));
            Params par3 = new Params() { from = 50000, to = 75000 };
            thread3.Start(par3);
            
            Thread thread4 = new Thread(new ParameterizedThreadStart(GetSum));
            Params par4 = new Params() { from = 75000, to = 100000 };
            thread4.Start(par4);

            Thread thread5 = new Thread(CheckForExistenceOfMinusNumbers);
            thread5.Start();
            



            Thread[] threads = { thread1, thread2, thread3, thread4, thread5 };

            while (!CheckThreadsForEnd(threads)) ;

            Console.WriteLine(sumOfNumbers);

        }
        static bool CheckThreadsForEnd(Thread[] aThreads)
        {
            foreach (Thread curThread in aThreads)
            {
                curThread.Join();

            }
            return true;
        }

        static void GetArrRangeNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < rangeNumbers.Length; i++)
            {
                rangeNumbers[i] = random.Next(1, 20);
            }
        }

        static void GetSum(object par)
        {
            var typedPar = par as Params;
            GetSum(typedPar.from, typedPar.to);
        }

        static void GetSum(int from, int to)
        {
            resetEvent.WaitOne();
            lock (block) 
            {
                for (int i = from; i < to; i++)
                {
                    sumOfNumbers += rangeNumbers[i];
                }
            }
            
        }

        static void CheckForExistenceOfMinusNumbers()
        {
           
            if (rangeNumbers.Any(x => x <= 0))
            {
                throw new Exception("Елемент масиву не може бути від'ємний, або дорівнвати 0");
            }
            else resetEvent.Set();
        }
    }
}
