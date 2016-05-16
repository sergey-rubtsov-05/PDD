using System.Collections.Generic;

namespace PDD.DataModel.Entity
{
    public class Test : Entity
    {
        public virtual string Description { get; set; }
        public virtual IList<Question> Questions { get; set; } 
    }
}
