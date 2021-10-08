using API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace API.Infrastructure.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
     where TEntity : class, IEntity, new()
     where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var created = context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

    //    public int Add<TEntity>(TEntity entity)
    //where TEntity : IIdentifier

        public int Add<TEntity>(TEntity entity) where TEntity : IIdentifier
        {
            using (var context = new TContext())
            {
                //context.Set<TEntity>().Add(entity);
                context.Add(entity);
                context.SaveChanges();
                return entity.Id;
            }
        }

        public bool Delete(TEntity entity)
        {
            bool deleteOk = false;
            try
            {
                using (var context = new TContext())
                {
                    var deletedEntity = context.Entry(entity);
                    deletedEntity.State = EntityState.Deleted;
                    context.SaveChanges();
                    deleteOk = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex.Message);
            }
            return deleteOk;


        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public bool Update(TEntity entity)
        {
            bool updateOk = false;
            try
            {
                using (var context = new TContext())
                {
                    var updatedEntity = context.Entry(entity);
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                    updateOk = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex.Message);
            }
            return updateOk;
        }
    }
}
