using System.Collections.Generic;

namespace PDD.DataModel.Entity
{
    public class Question : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Answer> Answers { get; set; }
        public virtual int TestId { get; set; }
        public virtual Test Test { get; set; }
    }
}
