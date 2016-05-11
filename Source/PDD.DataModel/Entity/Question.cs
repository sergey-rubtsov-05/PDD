using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDD.DataModel.Entity
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Answer> Answers { get; set; }
        public int TestId { get; set; }
        public virtual Test Test { get; set; }
    }
}
