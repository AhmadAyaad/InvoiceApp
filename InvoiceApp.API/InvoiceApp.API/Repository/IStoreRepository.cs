using InvoiceApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Repository
{
    public interface IStoreRepository
    {
        Task<List<Store>> GetStores();
    }
}
