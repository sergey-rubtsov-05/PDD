using System.Collections.Generic;

namespace PDD.DataModel.Entity
{
    public class Test : Entity
    {
        public string Description { get; set; }
        public List<Question> Questions { get; set; } 
    }
}
