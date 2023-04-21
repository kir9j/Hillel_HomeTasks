using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5
{
    public static class MathExtension
    {
        public static double[]ArrayOfSquareNumbers(this double[] root)
        {          
            double[] result = new double[root.Length];

            for (int i = 0; i < root.Length; i++)
            {

                if (root[i] < 0)
                {
                    throw new ArgumentException("Cannot calculate square root of a negative number.");
                }
                else
                {
                    result[i] = Math.Sqrt(root[i]);
                }
            }
            return result;
        }
    }
}
