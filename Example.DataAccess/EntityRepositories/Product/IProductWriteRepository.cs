using System;
using System.Collections.Generic;
using System.Text;
using Example.DataAccess.Database.WriteRepo;

namespace Example.DataAccess.EntityRepositories.Product
{
    public interface IProductWriteRepository : IWriteRepository<Entities.Product>
    {
    }
}
