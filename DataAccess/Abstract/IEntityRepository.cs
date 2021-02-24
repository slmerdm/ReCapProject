using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        //bu kod sayesinde filtreleme yaparız ve brandid , colorid gibi filtreleme listeye ihtiyacımız olmaz.
        
        //List<T> GetByBrandId(int BrandId);
    }
}
