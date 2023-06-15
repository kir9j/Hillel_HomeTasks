using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_16
{
    public class City 
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public Country Country { get; set; }
        public DateTime FoundationDate { get; set; }
        public bool IsCapital { get; set; }


    }
}
