using System.Linq;
using PDD.DataModel.Entity;

namespace PDD.EfDal
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        IQueryable<TEntity> GetList();

        bool Save(TEntity entity);
    }
}