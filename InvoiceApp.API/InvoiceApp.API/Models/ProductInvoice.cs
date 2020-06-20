using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Models
{
    public class ProductInvoice
    {
        public int Id { get; set; }
        public int ProductInvoiceId { get; set; }
        public int ProductId { get; set; }
        public int InvoiceId { get; set; }
        public int Code { get; set; }
        public decimal Price { get; set; }
        public int SotreId { get; set; }
        public decimal Discount { get; set; }
        public decimal Net { get; set; }
        public decimal Total { get; set; }
        public int Quantity { get; set; }
        public int UnitId { get; set; }
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}
