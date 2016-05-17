using System;
using System.Collections.Generic;

namespace PDD.DataModel.Entity
{
    public class TestResult : Entity
    {
        public virtual List<TestResultItem> TestResultItems { get; set; }
        public virtual int? PersonID { get; set; }
        public virtual Person Person { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual int? TestID { get; set; }
        public virtual Test Test { get; set; }
    }
}