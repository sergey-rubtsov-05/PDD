using FluentNHibernate.Mapping;
using PDD.DataModel.Entity;
using Inflector;

namespace PDD.NhDal.Mappings
{
    public class TestResultMap : ClassMap<TestResult>
    {
        public TestResultMap()
        {
            Table(nameof(TestResult).Pluralize());
            Id(c => c.Id);
            HasMany(c => c.TestResultItems)
                .Inverse()
                .Cascade.All();
            References(c => c.Person).Column("PersonId");
            Map(c => c.Date);
            References(c => c.Test).Column("TestId");
        }
    }
}