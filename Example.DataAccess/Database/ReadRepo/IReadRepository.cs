using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Example.DataAccess.Entities;

namespace Example.DataAccess.Database.ReadRepo
{
    public interface IReadRepository<TEntity> where TEntity : class, IEntity
    {
        Task<List<TEntity>> GetAll();
        Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetById(int id);
    }
}
