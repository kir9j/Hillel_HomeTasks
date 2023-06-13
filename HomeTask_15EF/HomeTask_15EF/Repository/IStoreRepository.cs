using HomeTask_15EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_15EF.Repository
{
    public interface IStoreRepository
    {
        Store GetStoreById(int storeId);
        void AddStore(Store store);
        void UpdateStore(Store store);
        void DeleteStore(int storeId);
    }
}
