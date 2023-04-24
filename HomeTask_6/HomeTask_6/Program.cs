using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Статистика для 10 розіграшів 
            List<List<int>> draws10 = new List<List<int>>(); 
            for (int i = 0; i < 10; i++)
            {
                draws10.Add(Lottery.Emit(15));            
            }
            Console.WriteLine("Never Appeared in 10 draws: " + String.Join(",", StatOperations.NeverAppeared(draws10)));
            Console.WriteLine("Most Appeared in 10 draws: " + String.Join(",", StatOperations.MostAppeared(draws10, 5)));
            Console.WriteLine();

            // Статистика для 50 розіграшів 
            List<List<int>> draws50 = new List<List<int>>(); 
            for (int i = 0; i < 50; i++)
            {
                draws50.Add(Lottery.Emit(20));
            }
            Console.WriteLine("Never Appeared in 50 draws: " + String.Join(",", StatOperations.NeverAppeared(draws50)));
            Console.WriteLine("Most Appeared in 50 draws: " + String.Join(",", StatOperations.MostAppeared(draws50, 5)));
            Console.WriteLine();

            // Статистика для 100 розіграшів 
            List<List<int>> draws100 = new List<List<int>>(); 
            for (int i = 0; i < 100; i++)
            {
                draws100.Add(Lottery.Emit(25));
            }
            Console.WriteLine("Never Appeared in 100 draws: " + String.Join(",", StatOperations.NeverAppeared(draws100)));
            Console.WriteLine("Most Appeared in 100 draws: " + String.Join(",", StatOperations.MostAppeared(draws100, 5)));

        }
    }
}
