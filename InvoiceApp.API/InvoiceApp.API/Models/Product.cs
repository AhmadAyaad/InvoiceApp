using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ICollection<ProductStore> ProductStores { get; set; }
        public ICollection<ProductInvoice> ProductInvoices { get; set; }

    }
}
