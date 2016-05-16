using System.Configuration;
using System.Data.SQLite;
using System.IO;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using PDD.DataModel.Entity;
using Configuration = NHibernate.Cfg.Configuration;

namespace PDD.NhDal
{
    public class NhibernateHelper
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["NhDatabase"].ConnectionString;
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = Fluently.Configure()
                        .Database(
                            SQLiteConfiguration.Standard.ConnectionString(
                                ConnectionString))
                        .Mappings(m => m.FluentMappings.AddFromAssembly(typeof (Repository<>).Assembly))
                        .ExposeConfiguration(BuildSchema)
                        .BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        private static void BuildSchema(Configuration config)
        {
            var dbFile = new SQLiteConnectionStringBuilder(ConnectionString).DataSource;
            if (File.Exists(dbFile))
                File.Delete(dbFile);

            new SchemaExport(config).Create(false, true);
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}