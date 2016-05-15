using System.Data.Entity;
using PDD.DataModel.Entity;
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedMember.Global

namespace PDD.EfDal
{
    [DbConfigurationType(typeof(SQLiteDbConfiguration))]
    public class PddDbContext: DbContext
    {
        private PddDbContext()
        {
        }

        public PddDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
		public DbSet<TestResult> TestResults { get; set; }
        public DbSet<TestResultItem> TestResultItems { get; set; }
    }
}
