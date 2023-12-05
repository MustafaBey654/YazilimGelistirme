
using Core.Entities;
using System.Linq.Expressions;


namespace Core.DataAccess
{
    //generic constraint
    // class : referans tip olabilir anlamında
    // IEntity : IEntity olabil veya kalıtım almalı olabilr IEntity den
    // new() : new lenebilir olmalı
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        //burada hem filtere hemde filtresiz işlem yapılabilir çünkü filter =null değeri verildi
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        //Burada filtre vermek zorunlu
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
