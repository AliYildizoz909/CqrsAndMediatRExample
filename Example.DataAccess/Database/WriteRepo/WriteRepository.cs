using Example.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.DataAccess.Database.WriteRepo
{
    public class WriteRepository<TEntity> : BaseRepository<TEntity>, IWriteRepository<TEntity> where TEntity : class, IEntity
    {
        public WriteRepository(ProductContext dbContext) : base(dbContext)
        {

        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void New(TEntity entity)
        {
            _dbSet.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        public void SaveChangesAsync()
        {
            base.SaveChanges();
        }

        public DbSet<TEntity> DbSet => _dbSet;
    }
}
