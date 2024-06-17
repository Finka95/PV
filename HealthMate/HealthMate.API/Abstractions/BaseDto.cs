namespace HealthMate.API.Abstractions
{
    public abstract record BaseDto
    {
        public Guid Id { get; set; }
    }
}
