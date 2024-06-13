namespace HealthMate.BLL.Models
{
    public class Health 
    {
        public required Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required Guid User { get; set; }
        public DateTime Date { get; set; }
        public int SystolicBloodPressure { get; set; }
        public int DiastolicBloodPressure { get; set; }
        public int HeartRate { get; set; }
        public double BloodSugar { get; set; }
        public double Cholesterol { get; set; }
        public ICollection<Note>? Notes { get; set; }
    }
}
