using HomeTask_15EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_15EF.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private readonly Context _context;

        public StoreRepository(Context context)
        {
            _context = context;
        }
        public void AddStore(Store store)
        {
            _context.Store.Add(store);
            _context.SaveChanges();
        }

        public void DeleteStore(int storeId)
        {
            var store = _context.Store.Find(storeId);
            if (store != null)
            {
                _context.Store.Remove(store);
                _context.SaveChanges();
            }
        }

        public Store GetStoreById(int storeId)
        {
            return _context.Store.Find(storeId);
        }

        public void UpdateStore(Store store)
        {
            _context.Store.Update(store);
            _context.SaveChanges();
        }
    }
}
