using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Api.Request
{
    public class NewProductRequest
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
