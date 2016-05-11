using System;
using System.Collections.Generic;

namespace PDD.DataModel.Entity
{
    public class TestResult
    {
        public int Id { get; set; }
        public List<TestResultItem> TestResultItems { get; set; }
        public int? PersonID { get; set; }
        public virtual Person Person { get; set; }
        public DateTime Date { get; set; }
        public int? TestID { get; set; }
        public virtual Test Test { get; set; }
    }
}