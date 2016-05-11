using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDD.DataModel.Entity
{
    public class Test
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Question> Questions { get; set; } 
    }
}
