namespace Studio5.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid CreatedById { get; set; }
        public Employee CreatedBy { get; set; }


    }
}
