using InvoiceApp.API.Dtos;
using InvoiceApp.API.Models;
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
    public class InvoiceController : ControllerBase
    {
        IInvoiceRepository _invoiceRepository;
        public InvoiceController(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        [HttpPost]
        public IActionResult CreateInvoice(InvoiceForCreate invoiceForCreate)
        {
            Invoice invoice = new Invoice
            {
                Code = invoiceForCreate.Code,
                Date = invoiceForCreate.Date,
                Net = invoiceForCreate.Net,
                ProductInvoices = invoiceForCreate.ProductInvoices,
                Taxes = invoiceForCreate.Taxes,
                Total = invoiceForCreate.Total
            };

            ProductInvoice productInvoice = new ProductInvoice
            {
                ProductInvoiceId = invoiceForCreate.ProductInvoiceId,
                InvoiceId = invoiceForCreate.InvoiceId,
                ProductId = invoiceForCreate.ProductId,
                UnitId = invoiceForCreate.UnitId,
                SotreId = invoiceForCreate.SotreId,
                Code = invoiceForCreate.Code,
                Invoice = invoiceForCreate.Invoice,
                Discount = invoiceForCreate.Discount,
                Net = invoiceForCreate.Net,
                Price = invoiceForCreate.Price,
                Product = invoiceForCreate.Product,
                Quantity = invoiceForCreate.Quantity,
                Total = invoiceForCreate.Total
            };
            bool created = _invoiceRepository.CreateInvoice(invoice, productInvoice);
            if (created)
                return Ok(created);
            return BadRequest();
        }

        [HttpGet("getinv")]
        public IActionResult GetInvoices()
        {
            return Ok(_invoiceRepository.GetInvoices());
        }
        [HttpGet("getprd")]
        public IActionResult GetProductInvoice()
        {
            return Ok(_invoiceRepository.GetProductInvoice());
        }
    }
}
