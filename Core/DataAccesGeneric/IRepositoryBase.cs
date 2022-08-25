using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccesGeneric
{
    public interface IRepositoryBase<T>
        where T : class,IEntity,new()
    {
        void add(T entity);
        void delete(T entity);
        void update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T get(Expression<Func<T, bool>> filter);
    }
}
