using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 9.0, 16.0, 36.0, 14.0, -1 };
            ArrayHandler arrayHandler = new ArrayHandler(array);

            arrayHandler.SquareRootEvent += ArrayHandler_SquareRootEvent;
            arrayHandler.SquareRoots(x => x % 1 == 0 && x > 5);
            



        }

        public static void ArrayHandler_SquareRootEvent(object sender, SquareRootEventArgs e)
        {
            Console.WriteLine($"{e.Root} {e.Number}");
            
        }
      
    }
}
