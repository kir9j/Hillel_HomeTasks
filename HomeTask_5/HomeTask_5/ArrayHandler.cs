using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5
{  

    public class ArrayHandler
    {

        public event EventHandler<SquareRootEventArgs> SquareRootEvent;

        public double[] arrayOfNumbers { get; set; }

        public ArrayHandler(double[] arrayOfNumbers)
        {
            this.arrayOfNumbers = arrayOfNumbers;
        }


        public double[] SquareRoots(Func<double, bool> filter = null)
        {
            
            var roots = arrayOfNumbers.ArrayOfSquareNumbers();

            List<double> resList = new List<double>();


            foreach (var item in roots)
            {
                if (filter.Invoke(item))
                {
                    resList.Add(item);
                
                }           
            }
            CreateEvent(roots,  x => x % 1 == 0);
            
            return resList.ToArray();
        }


        public void CreateEvent(double[] roots, Func<double, bool> filter = null)
        {
            
            for (int i = 0; i < roots.Length; i++)
            {
                if (filter.Invoke(roots[i]))
                {
                    var args = new SquareRootEventArgs(roots[i], arrayOfNumbers[i]);
                    OnSquareRootEvent(args);
                }

            }
        }


        protected virtual void OnSquareRootEvent(SquareRootEventArgs e)
        {
            SquareRootEvent?.Invoke(this, e);
        }       
    }
}
