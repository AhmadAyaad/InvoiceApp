﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Models
{
    public class Store
    {
        public int StoreId { get; set; }

        public string StoreName { get; set; }

        public ICollection<ProductStore> ProductStores { get; set; }
    }
}
