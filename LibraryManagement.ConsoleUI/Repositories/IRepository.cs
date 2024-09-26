using LibraryManagement.ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ConsoleUI.Repositories
{
    public interface IRepository<TEntity, TId> where TEntity : Entity<TId>, new()
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetById(TId id);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        ValueTask<TEntity> AddAsync(TEntity entity);
        void Delete(TId id);
        void Update(TId entity);
    }
}
