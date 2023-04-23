using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6
{
    public static class StatOperations
    {
        public static List<int> NeverAppeared(List<List<int>> emitList)
        {
            List<int> allNumbers = new List<int>();         
            for (int i = 0; i < emitList.Count; i++)
            {
                allNumbers.Add(i);
            }

            foreach(List<int> numbers in emitList)
    {
                foreach (int number in numbers)
                {
                    allNumbers.Remove(number);
                }
            }
            return allNumbers;

        }

        public static List<int> MostAppeared(List<List<int>> emitList, int n)
        {
            List<int> allNumbers = emitList.SelectMany(x => x).Distinct().ToList();

            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            foreach (int number in allNumbers)
            {
                numberCounts[number] = 0;
            }
            foreach (int number in emitList.SelectMany(x => x))
            {
                numberCounts[number]++;
            }
            return numberCounts.OrderByDescending(x => x.Value).Select(x => x.Key).Take(n).ToList();

        }
    }
}
