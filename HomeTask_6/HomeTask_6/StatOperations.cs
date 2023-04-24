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

        public static HashSet<int> GetAllNumbersSet(HashSet<int> appearedNumbers)
        {
            HashSet<int> allNumbers = new HashSet<int>();
            for (int i = 0; i <= appearedNumbers.Max(); i++)
            {
                if (!allNumbers.Contains(i))
                {
                    allNumbers.Add(i);
                }
            }
            return allNumbers;
        }

        public static HashSet<int> GetAppearedNumbers(List<List<int>> drawsList)
        {
            HashSet<int> appearedNumbers = new HashSet<int>();

            foreach (var list in drawsList)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    appearedNumbers.Add(list[i]);
                }
            }
            return appearedNumbers;
        }

        public static List<int> NeverAppeared(List<List<int>> drawsList)
        {
            var appearedNumbers = GetAppearedNumbers(drawsList);
            var allNumbers = GetAllNumbersSet(appearedNumbers);

            allNumbers.ExceptWith(appearedNumbers);

            return allNumbers.ToList();
        }



        public static List<int> MostAppeared(List<List<int>> drawsList, int n)
        {
            var appearedNumbers = GetAppearedNumbers(drawsList);
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            

            foreach (int number in appearedNumbers)
            {
                if (numberCounts.ContainsKey(number))
                {
                    numberCounts[number]++;
                }
                else
                {
                    numberCounts.Add(number, 1);
                }
            }

            List<int> mostAppearedList = new List<int>();
            while (n > 0 && numberCounts.Count > 0)
            {
                int maxCount = numberCounts.Values.Max();
                List<int> maxNumbers = numberCounts.Where(x => x.Value == maxCount).Select(x => x.Key).ToList();
                mostAppearedList.AddRange(maxNumbers);
                foreach (int number in maxNumbers)
                {
                    numberCounts.Remove(number);
                }
                n -= maxNumbers.Count;
            }

            return mostAppearedList;





            //    public static List<int> NeverAppeared(List<List<int>> emitList)
            //    {
            //        List<int> allNumbers = new List<int>();         
            //        for (int i = 0; i < emitList.Count; i++)
            //        {
            //            allNumbers.Add(i);
            //        }

            //        foreach(List<int> numbers in emitList)
            //{
            //            foreach (int number in numbers)
            //            {
            //                allNumbers.Remove(number);
            //            }
            //        }
            //        return allNumbers;

            //    }

            //public static List<int> MostAppeared(List<List<int>> emitList, int n)
            //{
            //    List<int> allNumbers = emitList.SelectMany(x => x).Distinct().ToList();

            //    Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            //    foreach (int number in allNumbers)
            //    {
            //        numberCounts[number] = 0;
            //    }
            //    foreach (int number in emitList.SelectMany(x => x))
            //    {
            //        numberCounts[number]++;
            //    }
            //    return numberCounts.OrderByDescending(x => x.Value).Select(x => x.Key).Take(n).ToList();

            //}
        }
    }
}
