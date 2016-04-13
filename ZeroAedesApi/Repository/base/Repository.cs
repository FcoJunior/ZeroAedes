using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ZeroAedes.Data.Entity;
using ZeroAedes.Data;

namespace ZeroAedes.Repository
{
    public abstract class Repository<TEntity> 
        where TEntity : Entity
    {
        /// <summary>
        /// Instance of database context
        /// </summary>
        protected Context Context = new Context();

        /// <summary>
        /// Create method
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Insert(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// Update method
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Get all actives elements
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = Context.Set<TEntity>()
                .Where(x => x.Active)
                .AsQueryable();
            return query;
        }

        /// <summary>
        /// Find element by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity GetById(int id)
        {
            TEntity entity = Context.Set<TEntity>()
                .Where(x => x.Id.Equals(id))
                .SingleOrDefault();

            return entity;
        }

        /// <summary>
        /// Disable element
        /// </summary>
        /// <param name="id"></param>
        public virtual void Disable(int id)
        {
            TEntity entity = GetById(id);
            entity.Active = false;

            Update(entity);
        }

        /// <summary>
        /// Save method
        /// </summary>
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
