using FluentNHibernate.Mapping;
using PDD.DataModel.Entity;

namespace PDD.NhDal.Mappings
{
    public class QuestionMap : ClassMap<Question>
    {
        public QuestionMap()
        {
            Id(c => c.Id);
            Map(c => c.Name);
            Map(c => c.Description);
            HasMany(c => c.Answers)
                .Inverse()
                .Cascade.All();
            References(c => c.Test);
            Table("Questions");
        }
    }
}