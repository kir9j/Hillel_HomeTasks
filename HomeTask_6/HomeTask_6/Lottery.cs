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
            int[] emitArr = new int[number];
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                emitArr[i] = (random.Next(number));
            }
            return emitArr.ToList();
        }
    }
}
