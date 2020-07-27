using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Business.Dtos
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
