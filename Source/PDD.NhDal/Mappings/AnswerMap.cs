using FluentNHibernate.Mapping;
using PDD.DataModel.Entity;

namespace PDD.NhDal.Mappings
{
    public class AnswerMap : ClassMap<Answer>
    {
        public AnswerMap()
        {
            Id(c => c.Id);
            Map(c => c.Name);
            References(c => c.Question);
            Map(c => c.Right);
            Table("Answers");
        }
    }
}