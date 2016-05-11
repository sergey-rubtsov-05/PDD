using System;
using System.Collections.Generic;
using System.Linq;
using PDD.DataModel.Entity;

namespace PDD.EfDal
{
    public class PersonRepository:BaseRepository
    {
        public IQueryable GetList()
        {
            var result = context.Persons.AsQueryable();
            return result;
        }
        public bool Save(Person instance)
        {
            var person = context.Persons.FirstOrDefault(p => p.Id == instance.Id);
            if (person == null)
            {
                context.Persons.Add(instance);
            }
            else
            {
                person.FirstName = instance.FirstName;
                person.LastName = instance.LastName;
                person.Patronymic = instance.Patronymic;
            }
            context.SaveChanges();
            return true;
        }
    }
}