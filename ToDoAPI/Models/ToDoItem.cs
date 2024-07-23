namespace ToDoAPI.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public bool IsComplete { get; set; }
    }
}
