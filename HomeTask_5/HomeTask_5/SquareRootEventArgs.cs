using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5
{
    public class SquareRootEventArgs : EventArgs
    {
       
        public double Root { get; set; }

        public double Number { get; set; }
        public SquareRootEventArgs(double root, double number)
        {
            Root = root;
            Number = number;
        }
    }
}
