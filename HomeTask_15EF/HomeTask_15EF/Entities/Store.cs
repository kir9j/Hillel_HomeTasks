using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_15EF.Entities
{
    public class Store
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("NetworkStoreId")]
        public int NetworkStoreId { get; set; }
        public StoreNetwork? StoreNetwork { get; set; }

        public ICollection<Product>? Products { get; set; }
        

    }
}
