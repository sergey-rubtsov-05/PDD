namespace PDD.DataModel.Entity
{
    public class Person : Entity
    {
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Patronymic { get; set; }
    }
}
