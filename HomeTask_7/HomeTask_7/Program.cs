using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeTask_7
{
    
    internal class Program 
    {
        public static List<double> resultList = new List<double>();
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ParameterizedThreadStart(FindNumbersWithSqrt));
            Params par1 = new Params() { from = 1, to = 20000};
            thread1.Start(par1);

            Thread thread2 = new Thread(new ParameterizedThreadStart(FindNumbersWithSqrt));
            Params par2 = new Params() { from = 20001, to = 39999};
            thread2.Start(par2);

            Thread thread3 = new Thread(new ParameterizedThreadStart(FindNumbersWithSqrt));
            Params par3 = new Params() { from = 40000, to = 59999};
            thread3.Start(par3);

            Thread thread4 = new Thread(new ParameterizedThreadStart(FindNumbersWithSqrt));
            Params par4 = new Params() { from = 60000, to = 79999};
            thread4.Start(par4);

            Thread thread5 = new Thread(new ParameterizedThreadStart(FindNumbersWithSqrt));
            Params par5 = new Params() { from = 80000, to = 100000};
            thread5.Start(par5);

            Thread [] threads = { thread1, thread2, thread3, thread4, thread5 };
            
            if (CheckThreadsForEnd(threads))
            {
                PrintList(resultList);
            }


        }
        static bool CheckThreadsForEnd(Thread[] aThreads)
        {
            foreach (Thread CurThread in aThreads)
            {
                if (!(CurThread.Join(TimeSpan.Zero)))
                {
                    return false;
                }

            }
            return true;
        }

        static void FindNumbersWithSqrt(object par)
        {
            var typedPar = par as Params;
            FindNumbersWithSqrt(typedPar.from, typedPar.to);
        }


        static void FindNumbersWithSqrt(int from, int to)
        {
           
            double[] numbers = new double[100000];
            for (int i = 0; i < 100000; i++)
            {
                numbers[i] = i;
            }

            for (int i = from; i < to; i++)
            {
                if (Math.Sqrt(numbers[i])% 1 == 0)
                {
                    lock (resultList)
                    {
                        resultList.Add(numbers[i]);
                    }
                }
            }
        }

        static void PrintList(List<double> list)
        {           
            for (int i = 0; i < resultList.Count; i++)
            {
                    Console.WriteLine(resultList[i]);
            }
            
        }
    }

    internal class Params
    {
        public int from = 0;
        public int to = 0;        
    }
}


