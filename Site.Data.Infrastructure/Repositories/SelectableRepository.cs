using PagedList.Core;
using Site.Model.Derived.EntityModel;
using Site.Model.Infrastructure.Input;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Site.Data.Infrastructure.Repositories
{
    public interface SelectableRepository<TEntity, TKey> :
        IRepository<TEntity, TKey> where TEntity : class, IEntityModel<TKey>
    {
        IQueryable<TEntity> GetList();
        IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> model);
        IPagedList<TEntity> GetList(IPagerInputModel model);
        TEntity Get(Expression<Func<TEntity, bool>> model);
        bool Exists(Expression<Func<TEntity, bool>> model);
        int Count(Expression<Func<TEntity, bool>> model);
    }
}
