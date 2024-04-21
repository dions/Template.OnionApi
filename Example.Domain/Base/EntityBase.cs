namespace Example.Domain.Base
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate{ get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
