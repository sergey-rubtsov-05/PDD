namespace PDD.DataModel.Entity
{
    public class TestResultItem : Entity
    {
        public int? QuestionID { get; set; }
        public virtual Question Question { get; set; }
        public int? AnswerId { get; set; }
        public virtual Answer Answer { get; set; }
        public int? TestResultId { get; set; }
        public virtual TestResult TestResult { get; set; }
    }
}