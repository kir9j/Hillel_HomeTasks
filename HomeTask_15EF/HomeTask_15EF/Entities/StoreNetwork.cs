using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_15EF.Entities
{
    public class StoreNetwork
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Store>? Stores { get; set; }
    }
}
