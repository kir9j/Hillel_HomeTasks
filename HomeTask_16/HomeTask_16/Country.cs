using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_16
{
    public class Country
    {
        public string Name { get; set; }
        public Сontinent Continent { get; set; }
        public List<City> Cities { get; set; } = new List<City>();
    }
}
