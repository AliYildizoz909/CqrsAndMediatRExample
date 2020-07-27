using System;
using System.Collections.Generic;
using System.Text;
using Example.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.DataAccess.Database.WriteRepo
{
    public interface IWriteRepository<TEntity> where TEntity : class, IEntity
    {
        void Update(TEntity entity);
        void New(TEntity entity);
        void Delete(TEntity entity);
        void SaveChangesAsync();
        DbSet<TEntity> DbSet { get; }
    }
}
