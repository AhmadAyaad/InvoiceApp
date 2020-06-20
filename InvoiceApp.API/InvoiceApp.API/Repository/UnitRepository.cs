using InvoiceApp.API.Data;
using InvoiceApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Repository
{
    public class UnitRepository : IUnitRepository
    {
        DataContext _context;

        public UnitRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Unit>> GetUnits()
        {
            var units = await _context.Units.ToListAsync();

            if (units != null)
                return units;
            return new List<Unit>();
        }
    }
}
