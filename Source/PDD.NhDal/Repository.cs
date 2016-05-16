using System;
using System.Linq;
using NHibernate;
using PDD.DataModel.Entity;
using PDD.DAL;

namespace PDD.NhDal
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        public IQueryable<TEntity> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Save(TEntity entity)
        {
            using (ISession session = NhibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(entity);
                transaction.Commit();
            }
            return true;
        }
    }
}
