using FluentNHibernate.Mapping;
using Inflector;
using PDD.DataModel.Entity;

namespace PDD.NhDal.Mappings
{
    public class TestMap : ClassMap<Test>
    {
        public TestMap()
        {
            Table(nameof(Test).Pluralize());
            Id(c => c.Id);
            Map(c => c.Description);
            HasMany(c => c.Questions)
                .Inverse()
                .Cascade.All();
        }
    }
}