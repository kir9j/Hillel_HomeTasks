using HomeTask_15EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_15EF.Repository
{
    public interface IStoreNetworkRepository
    {
        StoreNetwork GetNetworkById(int storeNetworkId);
        void AddNetwork(StoreNetwork storeNetwork);
        void UpdateNetwork(StoreNetwork storeNetwork);
        void DeleteNetwork(int storeNetworkId);
    }
}
