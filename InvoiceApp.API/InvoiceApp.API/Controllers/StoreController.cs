using InvoiceApp.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Controllers
{
    [Route("api/{Controller}")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        IStoreRepository _storeRepository;
        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetStores()
        {
            var stores = await _storeRepository.GetStores();
            if (stores != null)
                return Ok(stores);
            return NotFound();
        }
    }
}
