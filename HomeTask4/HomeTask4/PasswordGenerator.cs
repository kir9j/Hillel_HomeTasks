using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    static class PasswordGenerator
    {
        private static char[] allowedSymbols = { 'a', '@', '#', '$', 'B', '^', '&', '*', 'e', 'G' };

        public static string Generate()
        {  
            
            Random random = new Random(DateTime.Now.Millisecond);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < allowedSymbols.Length; i++)
            {
                int index = random.Next(allowedSymbols.Length);
                char symbol = allowedSymbols[index];

                sb.Append(symbol);
            }           
            return sb.ToString();   
        }
    }
}
