using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDD.DataModel.Entity;

namespace PDD.EfDal
{
    public class PddDbContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
		public DbSet<TestResult> TestResults { get; set; }
        public DbSet<TestResultItem> TestResultItems { get; set; }
    }
}
