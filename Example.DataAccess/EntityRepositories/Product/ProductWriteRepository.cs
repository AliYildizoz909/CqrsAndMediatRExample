using System;
using System.Collections.Generic;
using System.Text;
using Example.DataAccess.Database;
using Example.DataAccess.Database.WriteRepo;

namespace Example.DataAccess.EntityRepositories.Product
{
    public class ProductWriteRepository : WriteRepository<Entities.Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ProductContext dbContext) : base(dbContext)
        {
        }
    }
}
