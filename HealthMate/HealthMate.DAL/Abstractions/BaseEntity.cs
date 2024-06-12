namespace HealthMate.DAL.Abstractions
{
    public abstract class BaseEntity
    {
        public required Guid Id { get; set; }
    }
}
