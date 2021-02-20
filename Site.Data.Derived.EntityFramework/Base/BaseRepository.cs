using PagedList.Core;
using Site.Data.Infrastructure.Repositories;
using Site.Model.Derived.EntityModel;
using Site.Model.Infrastructure.Input;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Site.Data.Derived.EntityFramework.Base
{
    public class BaseRepository<OC, TEntity, TKey>
        : SelectableRepository<TEntity, TKey>,
        IInsertableRepository<TEntity, TKey>,
        IDeletableRepository<TEntity, TKey>,
        IUpdatableRepository<TEntity, TKey>
        where TEntity : class, IEntityModel<TKey> where OC : BaseContext, new()
    {
        public int Count(Expression<Func<TEntity, bool>> model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity model)
        {
            throw new System.NotImplementedException();
        }

        public bool Exists(Expression<Func<TEntity, bool>> model)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> model)
        {
            throw new NotImplementedException();
        }

        public IPagedList<TEntity> GetList(IPagerInputModel model)
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity model)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Update(TEntity model)
        {
            throw new System.NotImplementedException();
        }
    }
}