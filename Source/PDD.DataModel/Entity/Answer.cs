namespace PDD.DataModel.Entity
{
    public class Answer : Entity
    {
        public virtual string Name { get; set; }
        public virtual int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public virtual bool Right { get; set; }
    }
}