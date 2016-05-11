using System.Linq;
using PDD.DataModel.Entity;
using System.Collections.Generic;

namespace PDD.EfDal
{
    public class TestRepository:BaseRepository
    {
		public IEnumerable<Test> GetList()
		{
			var result = context.Tests.AsEnumerable();
			return result;
		}
		public bool Save(Test instance)
		{
			var item = context.Tests.FirstOrDefault(p => p.Id == instance.Id);
			if (item == null)
			{
				context.Tests.Add(instance);
			}
			else
			{
				item.Description = instance.Description;
				item.Questions = instance.Questions;
			}
			context.SaveChanges();
			return true;
		}
	}
}