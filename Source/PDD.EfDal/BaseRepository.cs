using System.Configuration;

namespace PDD.EfDal
{
    public abstract class BaseRepository
    {
        protected readonly PddDbContext Context;

        protected BaseRepository()
        {
            Context = new PddDbContext(ConfigurationManager.ConnectionStrings["PddDbContext"].ConnectionString);
        }
    }
}