using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Models
{
    public class Note : BaseModel
    {
        public string Content { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
    }
}
