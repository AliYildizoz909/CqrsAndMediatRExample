using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccess.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
