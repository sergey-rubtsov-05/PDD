using FluentNHibernate.Mapping;
using Inflector;
using PDD.DataModel.Entity;

namespace PDD.NhDal.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Table(nameof(Person).Pluralize());
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Patronymic);
        }
    }
}