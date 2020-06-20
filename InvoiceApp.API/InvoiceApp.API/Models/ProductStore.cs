using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Models
{
    public class ProductStore
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public Store Store { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
