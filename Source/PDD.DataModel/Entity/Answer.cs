using System;

namespace PDD.DataModel.Entity
{
    public class Answer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public bool Right { get; set; }
    }
}