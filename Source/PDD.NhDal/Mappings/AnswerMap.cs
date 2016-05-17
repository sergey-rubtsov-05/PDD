using FluentNHibernate.Mapping;
using Inflector;
using PDD.DataModel.Entity;

namespace PDD.NhDal.Mappings
{
    public class AnswerMap : ClassMap<Answer>
    {
        public AnswerMap()
        {
            Table(nameof(Answer).Pluralize());
            Id(c => c.Id);
            Map(c => c.Name);
            References(c => c.Question).Column(nameof(Answer.Question) + "Id");
            Map(c => c.Right);
        }
    }
}