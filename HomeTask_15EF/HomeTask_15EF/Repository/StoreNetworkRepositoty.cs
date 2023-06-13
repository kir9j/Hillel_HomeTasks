using HomeTask_15EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_15EF.Repository
{
    public class StoreNetworkRepositoty : IStoreNetworkRepository
    {
        private readonly Context _context;

        public StoreNetworkRepositoty(Context context)
        {
            _context = context;
        }
        public void AddNetwork(StoreNetwork storeNetwork)
        {
            _context.StoreNetwork.Add(storeNetwork);
            _context.SaveChanges();
        }

        public void DeleteNetwork(int storeNetworkId)
        {
            var network = _context.StoreNetwork.Find(storeNetworkId);
            if (network != null)
            {
                _context.StoreNetwork.Remove(network);
                _context.SaveChanges();
            }
        }

        public StoreNetwork GetNetworkById(int storeNetworkId)
        {
            return _context.StoreNetwork.Find(storeNetworkId);
        }

        public void UpdateNetwork(StoreNetwork storeNetwork)
        {
            _context.StoreNetwork.Update(storeNetwork);
            _context.SaveChanges();
        }
    }
}
