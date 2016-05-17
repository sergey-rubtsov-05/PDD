using FluentNHibernate.Mapping;
using Inflector;
using PDD.DataModel.Entity;

namespace PDD.NhDal.Mappings
{
    public class TestResultItemMap : ClassMap<TestResultItem>
    {
        public TestResultItemMap()
        {
            Table(nameof(TestResultItem).Pluralize());
            Id(c => c.Id);
            References(c => c.Question).Column("QuestionId");
            References(c => c.Answer).Column("AnswerId");
            References(c => c.TestResult).Column("TestResultId");
        }
    }
}