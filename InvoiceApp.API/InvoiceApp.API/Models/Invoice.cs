using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int Code { get; set; }

        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public decimal Taxes { get; set; }
        public decimal Net { get; set; }
        public ICollection<ProductInvoice> ProductInvoices { get; set; }
    }
}
