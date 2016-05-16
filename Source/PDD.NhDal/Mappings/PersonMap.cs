using FluentNHibernate.Mapping;
using PDD.DataModel.Entity;

namespace PDD.NhDal.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Patronymic);
            Table("People");
        }
    }
}