namespace Studio5.Models
{
    public class Employee : Person
    {
        public Guid Id { get; set; }
        public IEnumerable<Note>? Notes { get; set; }
    }
}
