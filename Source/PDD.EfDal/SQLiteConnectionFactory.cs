using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;

namespace PDD.EfDal
{
    // ReSharper disable once InconsistentNaming
    public class SQLiteConnectionFactory : IDbConnectionFactory
    {
        public DbConnection CreateConnection(string nameOrConnectionString)
        {
            return new SQLiteConnection(nameOrConnectionString);
        }
    }
}