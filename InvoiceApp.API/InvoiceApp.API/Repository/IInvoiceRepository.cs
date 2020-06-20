using InvoiceApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Repository
{
    public interface IInvoiceRepository
    {

        bool CreateInvoice(Invoice invoice, ProductInvoice productInvoice);

        List<Invoice> GetInvoices();
        List<ProductInvoice> GetProductInvoice();
    }
}
