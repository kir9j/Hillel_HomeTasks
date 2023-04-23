using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_6
{
    public static class Lottery
    {
        public static List<int> Emit(int number)
        {
            List<int> emitList = Enumerable.Range(1, number).ToList();
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                emitList.Add(random.Next(number));
            }
            return emitList;
        }
    }
}
