using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Models
{
    public class Note : IBaseModel
    {
        public Guid Id { get; set; } 
        public string Content { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
