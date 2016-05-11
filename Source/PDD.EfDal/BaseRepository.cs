namespace PDD.EfDal
{
    public class BaseRepository
    {
        public PddDbContext context;

        public BaseRepository()
        {
            this.context = new PddDbContext();
        }
    }
}