using InvoiceApp.API.Data;
using InvoiceApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Repository
{
    public class StoreRepository : IStoreRepository
    {
        DataContext _context;

        public StoreRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Store>> GetStores()
        {
            var stores = await _context.Stores.ToListAsync();
            if (stores != null)
                return stores;
            return new List<Store>();
        }
    }
}
