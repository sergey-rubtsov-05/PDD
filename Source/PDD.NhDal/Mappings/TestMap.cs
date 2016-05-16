using FluentNHibernate.Mapping;
using PDD.DataModel.Entity;

namespace PDD.NhDal.Mappings
{
    public partial class TestMap : ClassMap<Test>
    {
        public TestMap()
        {
            Id(c => c.Id);
            Map(c => c.Description);
            HasMany(c => c.Questions)
                .Inverse()
                .Cascade.All();
            Table("Tests");
        }
    }
}