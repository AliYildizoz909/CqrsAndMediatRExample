using System;
using System.Collections.Generic;
using System.Text;
using Example.DataAccess.Database;
using Example.DataAccess.Database.ReadRepo;

namespace Example.DataAccess.EntityRepositories.Product
{
    public class ProductReadRepository : ReadRepository<Entities.Product>, IProductReadRepository
    {
        public ProductReadRepository(ProductContext dbContext) : base(dbContext)
        {
        }
    }
}
