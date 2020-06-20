using InvoiceApp.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        IUnitRepository _unitRepository;
        public UnitController(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUnits()
        {
            var units = await _unitRepository.GetUnits();
            if (units != null)
                return Ok(units);

            return NotFound();
        }

    }
}
