using System.Data.Entity;
using System.Linq;
using PDD.DataModel.Entity;
using PDD.DAL;

namespace PDD.EfDal
{
    public class Repository<TEntity> : BaseRepository, IRepository<TEntity> where TEntity : Entity
    {
        public IQueryable<TEntity> GetList()
        {
            return Context.Set<TEntity>().AsQueryable();
        }

        public bool Save(TEntity entity)
        {
            var item = Context.Set<TEntity>().FirstOrDefault(p => p.Id == entity.Id);
            if (item == null)
            {
                Context.Set<TEntity>().Add(entity);
            }
            else
            {
                Context.Entry(entity).State = EntityState.Modified;
            }
            Context.SaveChanges();
            return true;
        }
    }
}