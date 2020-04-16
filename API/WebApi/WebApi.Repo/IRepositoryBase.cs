
using System;
using System.Linq;
using System.Linq.Expressions;

namespace WebApi.Repo
{
    public interface IRepositoryBase<TEntity>
    {
        IQueryable<TEntity> All();
         
        IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
