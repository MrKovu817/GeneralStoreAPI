using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GeneralStoreAPI.Models
{
    public class ProductEdit
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}
