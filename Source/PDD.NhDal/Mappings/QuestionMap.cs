using FluentNHibernate.Mapping;
using Inflector;
using PDD.DataModel.Entity;

namespace PDD.NhDal.Mappings
{
    public class QuestionMap : ClassMap<Question>
    {
        public QuestionMap()
        {
            Table(nameof(Question).Pluralize());
            Id(c => c.Id);
            Map(c => c.Name);
            Map(c => c.Description);
            HasMany(c => c.Answers)
                .Inverse()
                .Cascade.All();
            References(c => c.Test).Column(nameof(Question.Test) + "Id");
        }
    }
}