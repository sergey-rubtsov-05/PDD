using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PDD.DataModel.Entity;

namespace PDD.EfDal
{
    public class QuestionRepository:BaseRepository
    {
        public IEnumerable<Question> GetList()
        {
            var result = context.Questions.AsEnumerable();
            return result;
        }
        public bool Save(Question instance)
        {
            var item = context.Questions.FirstOrDefault(p => p.Id == instance.Id);
            if (item == null)
            {
                context.Questions.Add(instance);
            }
            else
            {
                item.Name = instance.Name;
                item.Description = instance.Description;
                item.Answers = instance.Answers;
            }
            context.SaveChanges();
            return true;
        }
    }
}