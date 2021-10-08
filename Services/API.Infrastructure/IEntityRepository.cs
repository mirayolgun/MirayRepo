using API.Infrastructure.Entities;
using API.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace API.Infrastructure
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //int Id { get; set;}
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        //void Add(T entity);
        int Add<T>(T item) where T : IIdentifier;
        bool Update(T entity);
        bool Delete(T entity);
    }
}
