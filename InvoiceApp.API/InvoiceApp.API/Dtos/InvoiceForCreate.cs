using InvoiceApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Dtos
{
    public class InvoiceForCreate
    {
        public int InvoiceId { get; set; }
        public int Code { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public decimal Taxes { get; set; }
        public decimal Net { get; set; }
        public ICollection<ProductInvoice> ProductInvoices { get; set; }
        public int ProductInvoiceId { get; set; }
        public int ProductId { get; set; }
        public int ProductInvoiceInoviceId { get; set; }

        public int ProductInvoiceCode { get; set; }
        public decimal Price { get; set; }
        public int SotreId { get; set; }
        public decimal Discount { get; set; }
        public decimal ProductInvoiceNet { get; set; }
        public decimal ProductInvoiceTotal { get; set; }
        public int Quantity { get; set; }
        public int UnitId { get; set; }
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}
