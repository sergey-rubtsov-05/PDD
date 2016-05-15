﻿using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.SQLite;
using System.Data.SQLite.EF6;

namespace PDD.EfDal
{
    // ReSharper disable once InconsistentNaming
    public class SQLiteDbConfiguration : DbConfiguration
    {
        public SQLiteDbConfiguration()
        {
            SetDefaultConnectionFactory(new SQLiteConnectionFactory());
            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
        }
    }
}