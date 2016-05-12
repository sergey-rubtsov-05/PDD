using System.Collections.Generic;

namespace PDD.DataModel.Entity
{
    public class Question : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Answer> Answers { get; set; }
        public int TestId { get; set; }
        public virtual Test Test { get; set; }
    }
}
