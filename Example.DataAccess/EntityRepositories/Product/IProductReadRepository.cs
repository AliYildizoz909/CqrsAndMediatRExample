using System;
using System.Collections.Generic;
using System.Text;
using Example.DataAccess.Database.ReadRepo;

namespace Example.DataAccess.EntityRepositories.Product
{
    public interface IProductReadRepository:IReadRepository<Entities.Product>
    {
    }
}
