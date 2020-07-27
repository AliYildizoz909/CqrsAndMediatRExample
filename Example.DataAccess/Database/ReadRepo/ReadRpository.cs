using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Example.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.DataAccess.Database.ReadRepo
{
    public class ReadRepository<TEntity> : BaseRepository<TEntity>, IReadRepository<TEntity> where TEntity : class, IEntity
    {
        public ReadRepository(ProductContext dbContext) : base(dbContext)
        {
        }

        public Task<List<TEntity>> GetAll()
        {
            return _dbSet.ToListAsync();
        }

        public Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> expression)
        {

            return _dbSet.Where(expression).ToListAsync();
        }

        public Task<TEntity> GetById(int id)
        {
            return _dbSet.FirstOrDefaultAsync(entity => entity.Id == id);
        }
    }
}
