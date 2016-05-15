using System.Linq;
using PDD.DataModel.Entity;

namespace PDD.DAL
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        IQueryable<TEntity> GetList();

        bool Save(TEntity entity);
    }
}