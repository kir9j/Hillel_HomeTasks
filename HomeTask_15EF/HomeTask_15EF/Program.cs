using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HomeTask_15EF.Entities;
using Microsoft.EntityFrameworkCore;
using HomeTask_15EF.Repository;
using System.Diagnostics.Metrics;

namespace HomeTask_15EF;

public class Program  
{
    public static void Main(string[] args)
    {
        using (var contex = new Context())
        {
            var store = new Store
            {
                Name = "My Store"
            };

            var networkRepository = new StoreRepository(contex);
            networkRepository.AddStore(store);
        }

        
    }
}

