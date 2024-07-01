namespace HealthMate.DAL.Abstractions
{
    public interface IModelWithUserId
    {
        public Guid UserId { get; set; }
    }
}
