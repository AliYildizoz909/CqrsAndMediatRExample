using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Example.DataAccess.Database.ReadRepo;
using Example.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.DataAccess.Database
{
    public abstract class BaseRepository<TEntitiy> where TEntitiy : class, IEntity
    {
        private ProductContext _dbContext;
        protected DbSet<TEntitiy> _dbSet;
        protected BaseRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntitiy>();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChangesAsync();
        }
    }
}
