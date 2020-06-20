using InvoiceApp.API.Data;
using InvoiceApp.API.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {

        DataContext _context;
        public InvoiceRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateInvoice(Invoice invoice, ProductInvoice productInvoice)
        {
            if (invoice != null && productInvoice != null)
            {
                _context.Invoices.Add(invoice);
                _context.ProductInvoices.Add(productInvoice);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Invoice> GetInvoices()
        {
           return _context.Invoices.ToList();
        }

        public List<ProductInvoice> GetProductInvoice()
        {
            return _context.ProductInvoices.ToList();
        }
    }
}
