using InvoiceApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Repository
{
    public interface IUnitRepository
    {
        Task<List<Unit>> GetUnits();
    }
}
